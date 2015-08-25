using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Net;
using liepa.rastija.lt;

namespace LieposNaujazodziai
{
    class Program
    {
        static void Main(string[] args)
        {
            RastijaServiceClient client = new RastijaServiceClient();

            List<string> sounds = new List<string>(), pictures = new List<string>();

            //using (System.IO.StreamWriter file = new StreamWriter(@"C:\Users\Mykolas\Downloads\LieposNaujazodziai\LieposNaujazodziai.csv"))
            using (System.IO.StreamWriter file = new StreamWriter(@"C:\Users\Mykolas\Downloads\LieposNaujazodziai\LieposNaujazodziai.owl"))
            {
                //file.WriteLine(@"ID, Key, Sarasine_forma, Pagrindine_forma, Antra_forma, Trecia_forma, Pagrindines_formos_garso_failas, Antros_formos_garso_failas, Trecios_formos_garso_failas, Rusis, Kalbos_dalis_1, Kalbos_dalis_2, Kirciuote, Kilme, Originali_forma, Giminiski_zodziai, Giminiski_zodziai_id, Papildoma_informacija, Reiksmes, Pastabos_vartotojams, Vartosenos_pavyzdziai, Vartojimo_sritys, Sasajos, Sasajos_id, Variantai, Variantai_id");
                file.WriteLine(LieposNaujazodziai.Properties.Resources.OWL_beginning);
                
                // xmlId => <term, hash>
                //Dictionary<ushort, Tuple<string, string>> allWords = client.GetList(null).Select(nr => client.GetItem(nr.XmlId)).Where(gir => gir.Count > 0).Select(gir => gir[0]).ToDictionary(n => n.Zodzio_id, n => Tuple.Create(n.Sarasine_forma, GetMD5(n.Zodzio_id.ToString()).Substring(0, 25)));
                NaujazodisRastija[] naujazodziai = client.GetList(null);
                Dictionary<int, int> xmlIds = naujazodziai.ToDictionary(nr => nr.Id, nr => nr.XmlId);

                foreach (NaujazodisRastija z in naujazodziai)
                {
                    GetItemResult zodis = client.GetItem(z.XmlId);
                    if (zodis.Count == 0)
                        continue;
                    Naujazodis n = zodis[0];


                    string key = GetKey(z.XmlId);// GetMD5(z.XmlId.ToString()).Substring(0, 25);//http://www.rastija.lt/isteklius#zodynas.Lietuvių_kalbos_naujažodžių_tartuvas.Resource
                    string dictionary = "Liepos-tartuvas", resource = "Lietuvių_kalbos_naujažodžių_tartuvas";//"tartuvas";
                    string commentPattern = "<!-- http://www.lexinfo.net/lmf#{0}/{1}-{2}-{3} --> ";
                    string namedIndividualOpenPattern = @"<owl:NamedIndividual rdf:about=""&lmf;{0}/{1}-{2}-{3}""> ";
                    string namedIndividualClose = "</owl:NamedIndividual>";
                    string rdftypePattern = @"<rdf:type rdf:resource=""&lmf;{0}""/> ";
                    string senseRelationTypePattern = "<type>{0}</type>";
                    string labelPattern = TagPattern("rdfs:label", "{0}");
                    string className;

                    string term = RemoveSuffixes(n.Sarasine_forma);//(n.Sarasine_forma.Contains(',') ? n.Sarasine_forma.Substring(0, n.Sarasine_forma.IndexOf(',')) : n.Sarasine_forma).Trim();


                    // ----------------------------------------
                    // ------------ LexicalEntry --------------
                    className = "LexicalEntry";
                    file.Write(commentPattern, dictionary, term, key, className.ToLower());
                    file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower());
                    file.Write(rdftypePattern, className);
                    //file.Write(@"<j.1:lexicon rdf:resource=""http://www.rastija.lt/isteklius#Resource.{0}""/>", resource);
                    file.Write(@"<j.1:lexicon rdf:resource=""http://www.rastija.lt/isteklius#zodynas.{0}.Resource""/>", resource);
                    file.Write(labelPattern, term);
                    file.Write(TagPattern("partOfSpeech", n.Kalbos_dalis_1));
                    for (int j = 1; j <= n.Reiksmes.Count; ++j)
                        file.Write(HasClassPattern("Sense", dictionary, term, key, j == 1 ? "" : j.ToString()));
                    file.Write(HasClassPattern("Lemma", dictionary, term, key));
                    file.Write(HasClassPattern("WordForm", dictionary, term, key));
                    file.WriteLine(namedIndividualClose);

                    // <note, rank>
                    List<string> notes = new List<string>();
                    // <related term, rank, related term id>
                    List<Tuple<string, int, int?>> relations = new List<Tuple<string, int, int?>>();
                    // <variant term, rank, variant term id>
                    List<Tuple<string, int, int?>> variants = new List<Tuple<string, int, int?>>();
                    // <example, rank>
                    List<Tuple<string, int>> examples = new List<Tuple<string, int>>();

                    for (int r = 0; r < n.Reiksmes.Count; ++r)
                    {
                        if (n.Reiksmes[r].Pastabos_vartotojams != null && n.Reiksmes[r].Pastabos_vartotojams.Length > 0)
                            notes.Add(n.Reiksmes[r].Pastabos_vartotojams);
                        //int t1 = 0, t2 = 0;
                        //if (n.Reiksmes[r].Reiksmes_sasajos != null)
                        //    relations.AddRange(n.Reiksmes[r].Reiksmes_sasajos.Select(rs => Tuple.Create(rs.Sasajos_zodzio_tekstas, ++t1, (int?)rs.Sasajos_zodzio_id)));
                        //if (n.Reiksmes[r].Reiksmes_variantai != null)
                        //    variants.AddRange(n.Reiksmes[r].Reiksmes_variantai.Select(rv => Tuple.Create(rv.Varianto_zodzio_tekstas, ++t2, (int?)rv.Varianto_zodzio_id)));

                        // ----------------------------------------
                        // ---------------- Sense -----------------
                        className = "Sense";
                        file.Write(commentPattern, dictionary, term, key, className.ToLower() + (r == 0 ? "" : (r + 1).ToString()));
                        //file.Write("\t");
                        file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower() + (r == 0 ? "" : (r + 1).ToString()));
                        file.Write(labelPattern, term + "-" + className.ToLower());
                        file.Write(rdftypePattern, className);
                        file.Write(HasClassPattern("SubjectField", dictionary, term, key));
                        file.Write(HasClassPattern("Definition", dictionary, term, key, r == 0 ? "" : (r + 1).ToString()));
                        if (n.Giminiski_zodziai != null)
                            for (int j = 0; j < n.Giminiski_zodziai.Count; ++j)
                                file.Write(HasClassPattern("SenseRelation", dictionary, term, key, "-gim-" + (j + 1)));
                        if (n.Reiksmes[r].Pastabos_vartotojams != null && n.Reiksmes[r].Pastabos_vartotojams.Length > 0)
                            file.Write(HasClassPattern("SenseRelation", dictionary, term, key, "-pas-" + notes.Count));
                        if (n.Reiksmes[r].Reiksmes_sasajos != null)
                            for (int j = 0; j < n.Reiksmes[r].Reiksmes_sasajos.Count; ++j)
                            {
                                // FIXIT: Galbūt WrittenForm turėtų būt su siffx'u?
                                relations.Add(Tuple.Create(RemoveSuffixes(n.Reiksmes[r].Reiksmes_sasajos[j].Sasajos_zodzio_tekstas), j + 1, (int?)n.Reiksmes[r].Reiksmes_sasajos[j].Sasajos_zodzio_id));
                                file.Write(HasClassPattern("SenseRelation", dictionary, term, key, "-sąs-" + relations.Count));
                            }
                        if (n.Reiksmes[r].Reiksmes_variantai != null)
                            for (int j = 0; j < n.Reiksmes[r].Reiksmes_variantai.Count; ++j)
                            {
                                variants.Add(Tuple.Create(RemoveSuffixes(n.Reiksmes[r].Reiksmes_variantai[j].Varianto_zodzio_tekstas), j + 1, (int?)n.Reiksmes[r].Reiksmes_variantai[j].Varianto_zodzio_id));
                                file.Write(HasClassPattern("SenseRelation", dictionary, term, key, "-kit-" + variants.Count));
                            }
                        int t = 0;
                        if (n.Reiksmes[r].Naujazodzio_vartosenos_pavyzdziai != null && n.Reiksmes[r].Naujazodzio_vartosenos_pavyzdziai.Length > 0)
                        {
                            foreach (string example in n.Reiksmes[r].Naujazodzio_vartosenos_pavyzdziai.Split(new string[] { "<br />" }, StringSplitOptions.RemoveEmptyEntries))
                            {
                                string p = example;
                                Match m;
                                while ((m = Regex.Match(p, @"#\d+\[([^\]]+)\]")).Success)
                                    p = p.Remove(m.Index, m.Length).Insert(m.Index, m.Groups[1].Value);
                                examples.Add(Tuple.Create(p.Trim().Replace("<strong>", "<b>").Replace("</strong>", "</b>"), ++t));
                                file.Write(HasClassPattern("SenseExample", dictionary, term, key, "-" + examples.Count));
                            }
                        }
                        file.WriteLine(namedIndividualClose);

                        // ----------------------------------------
                        // ------------- Definition ---------------
                        className = "Definition";
                        file.Write(commentPattern, dictionary, term, key, className.ToLower() + (r == 0 ? "" : (r + 1).ToString()));
                        //file.Write("\t\t");
                        file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower() + (r == 0 ? "" : (r + 1).ToString()));
                        file.Write(labelPattern, CData(n.Reiksmes[r].Reiksmes_apibreztis));
                        file.Write(rdftypePattern, className);
                        file.Write(HasClassPattern("TextRepresentation", dictionary, term, key, r == 0 ? "" : (r + 1).ToString()));
                        file.WriteLine(namedIndividualClose);

                        // ----------------------------------------
                        // --------- TextRepresentation -----------
                        className = "TextRepresentation";
                        file.Write(commentPattern, dictionary, term, key, className.ToLower() + (r == 0 ? "" : (r + 1).ToString()));
                        //file.Write("\t\t\t");
                        file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower() + (r == 0 ? "" : (r + 1).ToString()));
                        file.Write(labelPattern, CData(n.Reiksmes[r].Reiksmes_apibreztis));
                        file.Write(rdftypePattern, className);
                        file.Write(TagPattern("writtenForm", CData(n.Reiksmes[r].Reiksmes_apibreztis + (n.Reiksmes[r].Vaizdo_failas == null ? "" : string.Format(@"<img src=""{0}"" alt=""{1}"" width=""238"" />", n.Reiksmes[r].Vaizdo_failas, n.Reiksmes[r].Tekstas_vaizdui)))));
                        file.WriteLine(namedIndividualClose);
                    }

                    // ----------------------------------------
                    // ------------ SenseRelation -------------
                    // ----------- Giminiškas žodis -----------
                    className = "SenseRelation";
                    if (n.Giminiski_zodziai != null)
                        for (int j = 0; j < n.Giminiski_zodziai.Count; ++j)
                        {
                            file.Write(commentPattern, dictionary, term, key, className.ToLower() + "-gim-" + (j + 1).ToString());
                            //file.Write("\t");
                            file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower() + "-gim-" + (j + 1).ToString());
                            // FIXIT: Galbūt WrittenForm turėtų būt su siffx'u?
                            file.Write(labelPattern, RemoveSuffixes(n.Giminiski_zodziai[j].Giminisko_zodzio_tekstas).ToLower());
                            file.Write(rdftypePattern, className);
                            file.Write(senseRelationTypePattern, "Giminiškas žodis");
                            file.Write(TagPattern("writtenForm", RemoveSuffixes(n.Giminiski_zodziai[j].Giminisko_zodzio_tekstas)));
                            file.Write(TagPattern("rank", (j + 1).ToString()));
                            if (n.Giminiski_zodziai[j].Giminisko_zodzio_id != null && xmlIds.ContainsKey((int)n.Giminiski_zodziai[j].Giminisko_zodzio_id))
                                file.Write(SenseRelatedTo(dictionary, RemoveSuffixes(n.Giminiski_zodziai[j].Giminisko_zodzio_tekstas), xmlIds[(int)n.Giminiski_zodziai[j].Giminisko_zodzio_id]));
                            file.WriteLine(namedIndividualClose);
                        }
                    // --------------- Pastabos ---------------
                    for (int j = 0; j < notes.Count; ++j)
                    {
                        file.Write(commentPattern, dictionary, term, key, className.ToLower() + "-pas-" + (j + 1).ToString());
                        //file.Write("\t");
                        file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower() + "-pas-" + (j + 1).ToString());
                        file.Write(labelPattern, CData(notes[j]));
                        file.Write(rdftypePattern, className);
                        file.Write(senseRelationTypePattern, "Pastabos");
                        file.Write(TagPattern("writtenForm", CData(notes[j])));
                        file.WriteLine(namedIndividualClose);
                    }
                    // --------------- Sąsajos ----------------
                    for (int j = 0; j < relations.Count; ++j)
                    {
                        file.Write(commentPattern, dictionary, term, key, className.ToLower() + "-sąs-" + (j + 1).ToString());
                        //file.Write("\t");
                        file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower() + "-sąs-" + (j + 1).ToString());
                        file.Write(labelPattern, relations[j].Item1.ToLower());
                        file.Write(rdftypePattern, className);
                        file.Write(senseRelationTypePattern, "Sąsaja");
                        file.Write(TagPattern("writtenForm", relations[j].Item1));
                        file.Write(TagPattern("rank", relations[j].Item2.ToString()));
                        if (relations[j].Item3 != null && xmlIds.ContainsKey((int)relations[j].Item3))
                            file.Write(SenseRelatedTo(dictionary, relations[j].Item1, xmlIds[(int)relations[j].Item3]));
                        file.WriteLine(namedIndividualClose);
                    }
                    // -------------- Variantai ---------------
                    for (int j = 0; j < variants.Count; ++j)
                    {
                        file.Write(commentPattern, dictionary, term, key, className.ToLower() + "-kit-" + (j + 1).ToString());
                        //file.Write("\t");
                        file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower() + "-kit-" + (j + 1).ToString());
                        file.Write(labelPattern, variants[j].Item1.ToLower());
                        file.Write(rdftypePattern, className);
                        file.Write(senseRelationTypePattern, "Kitas variantas");
                        file.Write(TagPattern("writtenForm", variants[j].Item1));
                        file.Write(TagPattern("rank", variants[j].Item2.ToString()));
                        if (variants[j].Item3 != null && xmlIds.ContainsKey((int)variants[j].Item3))
                            file.Write(SenseRelatedTo(dictionary, variants[j].Item1, xmlIds[(int)variants[j].Item3]));
                        file.WriteLine(namedIndividualClose);
                    }

                    // ----------------------------------------
                    // ------------- SenseExample -------------
                    className = "SenseExample";
                    for (int j = 0; j < examples.Count; ++j)
                    {
                        file.Write(commentPattern, dictionary, term, key, className.ToLower() + "-" + (j + 1).ToString());
                        //file.Write("\t");
                        file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower() + "-" + (j + 1).ToString());
                        file.Write(labelPattern, CData(examples[j].Item1));
                        file.Write(rdftypePattern, className);
                        file.Write(TagPattern("text", CData(examples[j].Item1)));
                        file.Write(TagPattern("rank", examples[j].Item2.ToString()));
                        file.WriteLine(namedIndividualClose);
                    }

                    // ----------------------------------------
                    // ------------ SubjectField --------------
                    className = "SubjectField";
                    file.Write(commentPattern, dictionary, term, key, className.ToLower());
                    //file.Write("\t\t");
                    file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower());
                    file.Write(labelPattern, n.Rusis);
                    file.Write(rdftypePattern, className);
                    file.Write(TagPattern("status", n.Rusis));
                    file.WriteLine(namedIndividualClose);

                    // ----------------------------------------
                    // ---------------- Lemma -----------------
                    className = "Lemma";
                    file.Write(commentPattern, dictionary, term, key, className.ToLower());
                    //file.Write("\t");
                    file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower());
                    file.Write(labelPattern, term + "-" + className.ToLower());
                    file.Write(rdftypePattern, className);
                    file.Write(TagPattern("writtenForm", term));
                    file.Write(TagPattern("accented_term", n.Pagrindine_forma));
                    if (n.Reiksmes.Any(r => r.Reiksmes_vartojimo_sritys.Count > 0))
                        file.Write(TagPattern("scope", String.Join(", ", n.Reiksmes.SelectMany(r => r.Reiksmes_vartojimo_sritys).Distinct())));
                    if (!string.IsNullOrEmpty(n.Kilme) || !string.IsNullOrEmpty(n.Originali_forma))
                        file.Write(TagPattern("origin", CData(n.Kilme + (!string.IsNullOrEmpty(n.Kilme) && !string.IsNullOrEmpty(n.Originali_forma) ? ", " : "") + n.Originali_forma)));
                    if (!string.IsNullOrEmpty(n.Papildoma_informacija))
                        file.Write(TagPattern("comment", CData(n.Papildoma_informacija)));
                    file.WriteLine(namedIndividualClose);

                    // ----------------------------------------
                    // -------------- WordForm ----------------
                    className = "WordForm";
                    file.Write(commentPattern, dictionary, term, key, className.ToLower());
                    //file.Write("\t");
                    file.Write(namedIndividualOpenPattern, dictionary, term, key, className.ToLower());
                    file.Write(labelPattern, term + "-" + className.ToLower());
                    file.Write(rdftypePattern, className);
                    if (!string.IsNullOrEmpty(n.Kirciuote))
                        file.Write(TagPattern("accentuation", CData(n.Kirciuote)));
                    if (!string.IsNullOrEmpty(n.Pagrindines_formos_garso_failas))
                        file.Write(TagPattern("sound", n.Pagrindines_formos_garso_failas.Replace("http://naujazodziai.lki.lt/garsai/", "https://www.xn--ratija-ckb.lt/dictionaries_media/lietuviu_kalbos_naujazodziu_tartuvas/")));
                    file.WriteLine(namedIndividualClose);

                    //*/
                    continue;






                    List<string> row = new List<string>();
                    //row.Add(n.Zodzio_id.ToString());
                    //row.Add(GetMD5(z.XmlId.ToString()).Substring(0, 25));
                    //row.Add(n.Sarasine_forma);
                    //row.Add(n.Pagrindine_forma);
                    //row.Add(n.Antra_forma);       // Nenaudojama
                    //row.Add(n.Trecia_forma);      // Nenaudojama
                    //row.Add(n.Pagrindines_formos_garso_failas);
                    //row.Add(n.Antros_formos_garso_failas);        // Nenaudojama
                    //row.Add(n.Trecios_formos_garso_failas);       // Nenaudojama
                    //row.Add(n.Rusis);
                    //row.Add(n.Kalbos_dalis_1);
                    //row.Add(n.Kalbos_dalis_2);      // Nera
                    //row.Add(n.Kirciuote);
                    //row.Add(n.Kilme);
                    //row.Add(n.Originali_forma);
                    //row.Add(n.Giminiski_zodziai == null ? "" : String.Join(";;", n.Giminiski_zodziai.Select(g => g.Giminisko_zodzio_tekstas)));
                    //row.Add(n.Giminiski_zodziai == null ? "" : String.Join(";;", n.Giminiski_zodziai.Select(g => g.Giminisko_zodzio_id)));
                    //row.Add(n.Papildoma_informacija);
                    //row.Add(String.Join(";;", n.Reiksmes.OrderBy(r => r.Reiksmes_nr).Select(r => r.Reiksmes_apibreztis + (r.Vaizdo_failas == null ? "" : " <img src=\"" + r.Vaizdo_failas + "\" alt=\"" + r.Tekstas_vaizdui + "\" />"))));
                    //row.Add(String.Join(";;", n.Reiksmes.OrderBy(r => r.Reiksmes_nr).Select(r => r.Pastabos_vartotojams)));

                    List<string> vartosenosPavyzdiai = new List<string>();
                    foreach (string pvz in n.Reiksmes.OrderBy(r => r.Reiksmes_nr).Select(r => r.Naujazodzio_vartosenos_pavyzdziai))
                    {
                        string p = pvz;
                        if (pvz != null)
                        {
                            MatchCollection mc = Regex.Matches(pvz, @"#\d+\[([^\]]+)\]");
                            for (int i = mc.Count - 1; i >= 0; --i)
                                p = p.Remove(mc[i].Index, mc[i].Length).Insert(mc[i].Index, mc[i].Groups[1].Value);
                        }
                        vartosenosPavyzdiai.Add(p);
                    }
                    //row.Add(String.Join(";;", vartosenosPavyzdiai));

                    //row.Add(String.Join(";;", n.Reiksmes.OrderBy(r => r.Reiksmes_nr).Select(r => String.Join("::", r.Reiksmes_vartojimo_sritys))));
                    //row.Add(String.Join(";;", n.Reiksmes.OrderBy(r => r.Reiksmes_nr).Select(r => r.Reiksmes_sasajos == null ? "" : String.Join("::", r.Reiksmes_sasajos.Select(s => s.Sasajos_zodzio_tekstas)))));
                    //row.Add(String.Join(";;", n.Reiksmes.OrderBy(r => r.Reiksmes_nr).Select(r => r.Reiksmes_sasajos == null ? "" : String.Join("::", r.Reiksmes_sasajos.Select(s => s.Sasajos_zodzio_id.ToString())))));
                    //row.Add(String.Join(";;", n.Reiksmes.OrderBy(r => r.Reiksmes_nr).Select(r => r.Reiksmes_variantai == null ? "" : String.Join("::", r.Reiksmes_variantai.Select(s => s.Varianto_zodzio_tekstas)))));
                    //row.Add(String.Join(";;", n.Reiksmes.OrderBy(r => r.Reiksmes_nr).Select(r => r.Reiksmes_variantai == null ? "" : String.Join("::", r.Reiksmes_variantai.Select(s => s.Varianto_zodzio_id.ToString())))));
                    

                    //if (n.Reiksmes.Any(r => !String.IsNullOrEmpty(r.Pastabos_skoliniui)))
                    //    Console.WriteLine("Yra pastabu");
                    //if (n.Reiksmes.Any(r => !String.IsNullOrEmpty(r.Skolinio_vartosenos_pavyzdziai)))
                    //    Console.WriteLine("Yra vartosenos pavyzdziu");

                    //file.WriteLine(String.Join(";", row.Select(item => @"""" + (item == null ? "" : item.Replace(@"""", @"""""")) + @"""")));

                    if (n.Pagrindines_formos_garso_failas != null)
                        sounds.Add(n.Pagrindines_formos_garso_failas);
                    if (n.Antros_formos_garso_failas != null)
                        sounds.Add(n.Antros_formos_garso_failas);
                    if (n.Trecios_formos_garso_failas != null)
                        sounds.Add(n.Trecios_formos_garso_failas);
                    pictures.AddRange(n.Reiksmes.Select(r => r.Vaizdo_failas).Where(f => !String.IsNullOrEmpty(f)));
                }

                file.WriteLine(LieposNaujazodziai.Properties.Resources.OWL_ending);
            }

            /*
            foreach (string sound in sounds)
                using (WebResponse response = WebRequest.Create(sound).GetResponse())
                    if (response.ContentType.StartsWith("audio/"))
                        using (FileStream fileStream = File.Create(@"C:\Users\Administrator\Downloads\LieposNaujazodziai\garsai" + sound.Substring(sound.LastIndexOf('/'))))
                            response.GetResponseStream().CopyTo(fileStream);
            foreach (string picture in pictures)
                using (WebResponse response = WebRequest.Create(picture).GetResponse())
                    if (response.ContentType.StartsWith("image/"))
                        using (FileStream fileStream = File.Create(@"C:\Users\Administrator\Downloads\LieposNaujazodziai\vaizdai" + picture.Substring(picture.LastIndexOf('/'))))
                            response.GetResponseStream().CopyTo(fileStream);
            //*/

            client.Close();
        }

        static string HasClassPattern(string className, string dictionary, string term, string key, string suffix = "")
        {
            return string.Format(@"<has{0} rdf:resource=""&lmf;{1}/{2}-{3}-{4}{5}""/> ", className, dictionary, term, key, className.ToLower(), suffix);
        }
        static string TagPattern(string tag, string data)
        {
            return string.Format("<{0}>{1}</{0}> ", tag, data);
        }
        static string CData(string data)
        {
            return string.Format("<![CDATA[{0}]]>", data);
        }
        static string SenseRelatedTo(string dictionary, string term, int id)
        {
            return string.Format(@"<senseRelatedTo rdf:resource=""&lmf;{0}/{1}-{2}-lexicalentry""/>", dictionary, term, GetKey(id));
        }
        static string RemoveSuffixes(string term)
        {
            return (term.Contains(',') ? term.Substring(0, term.IndexOf(',')) : term).Trim();
            //(n.Sarasine_forma.Contains(',') ? n.Sarasine_forma.Substring(0, n.Sarasine_forma.IndexOf(',')) : n.Sarasine_forma).Trim();
        }

        static MD5 md5 = MD5.Create();
        public static string GetMD5(string input)
        {
            //return String.Join("", md5.ComputeHash(Encoding.UTF8.GetBytes(input)).Select(b => b.ToString("x2")));
            StringBuilder sb = new StringBuilder();
            md5.ComputeHash(Encoding.UTF8.GetBytes(input)).ToList().ForEach(b => sb.Append(b.ToString("x2")));
            return sb.ToString();
            //return new string(md5.ComputeHash(Encoding.UTF8.GetBytes(input)).Select(b => b.ToString("x2")).ToArray());

            //byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            //foreach (byte b in data)
            //    sb.Append(b.ToString("x2"));
            //return sb.ToString();
        }
        static string GetKey(int input)
        {
            return GetMD5(input.ToString()).Substring(0, 25);
        }
    }
}
