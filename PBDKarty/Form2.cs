using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBDKarty;

namespace PBDKarty
{



    public partial class BazaDanych : Form
    {
        public static string ID, Data_Dolaczenia, Data_Urodzenia, E_mail, ode_mail, odnazwa_talii, ode_mails, odnazwakarty, odkosztk, odtypk, odedycjak, odopisk, odautorgrafikik;
        public static string id_Statystyki, wygrane, przegrane, remisy, id_Gracza, id_Talii;
        public static string id_Karty, nazwa_Karty, grafika, koszt, typ, edycja, opis, rok, autor_Grafiki;
        public static string id_talii_t, nazwa_Talii, ilosc_Kart, odnazwa_kartyt, odnazwa_taliit;
        public int odgID, odsID, odgIDs, odtID, odwygranes, odprzegranes, odremisys, odiloscsztukt, odkartyID, odkreaturyID, odmanyid, odplansewalkerid, odrokk, odatakk, odobronak, odpunktylojk;

        private void Przycisk_Dodaj_Gracza_Click(object sender, EventArgs e)
        {
            using (PBDKarty.Kartyv1Entities se = new Kartyv1Entities())
            {
                try
                {

                    var newInstructor = new Gracz
                    {

                        ID_Gracza = Convert.ToInt32(ID),
                        Data_Dolaczenia = Convert.ToDateTime(Data_Dolaczenia),
                        Data_Urodzin = Convert.ToDateTime(Data_Urodzenia),
                        E_mail = E_mail,
                        ID_Talii = Convert.ToInt32(id_Talii)
                    };

                    se.Gracz.Add(newInstructor);
                    se.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            BoxIDGracza.Clear();
            BoxData_Urodzin.Clear();
            BoxData_Dolaczenia.Clear();
            BoxE_mail.Clear();
            BoxID_Talii.Clear();
        }

        private void Przycisk_Dodaj_Statystyke_Click_1(object sender, EventArgs e)
        {
            using (PBDKarty.Kartyv1Entities se = new Kartyv1Entities())
            {
                try
                {
                    var newInstructor = new Statystyka
                    {
                        ID_Gracza = Convert.ToInt32(BoxID_Gracza_S.Text),
                        ID_Statystyki = Convert.ToInt32(BoxID_Statystyki.Text),
                        Wygrane = Convert.ToInt32(BoxWygrane.Text),
                        Przegrane = Convert.ToInt32(BoxPrzegrane.Text),
                        Remisy = Convert.ToInt32(BoxRemisy.Text)
                    };
                    se.Statystyka.Add(newInstructor);
                    se.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            BoxID_Gracza_S.Clear();
            BoxID_Statystyki.Clear();
            BoxWygrane.Clear();
            BoxPrzegrane.Clear();
            BoxRemisy.Clear();
        }

        public DateTime oddata_dolaczenia, oddata_urodzin;
        bool odtappedk;
        public BazaDanych()
        {

            InitializeComponent();
        }
        private void Przycisk_Dodaj_Karte_Click_1(object sender, EventArgs e)
        {
            using (PBDKarty.Kartyv1Entities se = new Kartyv1Entities())
            {
                try
                {
                    var newInstructor = new Karty
                    {
                        ID_Karty = Convert.ToInt32(BoxID_Karty.Text),
                        Nazwa_Karty = BoxNazwa_Karty.Text,
                        Koszt = BoxKoszt.Text,
                        Typ = BoxTyp.Text,
                        Grafika = grafika,
                        Edycja = BoxEdycja.Text,
                        Opis = BoxOpis.Text,
                        Rok = Convert.ToInt32(BoxRok.Text),
                        Autor_Grafiki = BoxAutor_Grafiki.Text

                    };
                    se.Karty.Add(newInstructor);
                    se.SaveChanges();
                    if (!string.IsNullOrWhiteSpace(boxidkreatury.Text))
                    {
                        var n2 = new Kreatury
                        {
                            ID_Kreatury = Convert.ToInt32(boxidkreatury.Text),
                            Atak = Convert.ToInt32(boxatak.Text),
                            Obrona = Convert.ToInt32(boxatak.Text),
                            ID_Karty = Convert.ToInt32(BoxID_Karty.Text)
                        };
                        se.Kreatury.Add(n2);
                        se.SaveChanges();
                    }
                    if (!string.IsNullOrWhiteSpace(boxidmany.Text))
                    {
                        var n3 = new Mana
                        {
                            ID_Mana = Convert.ToInt32(boxidmany.Text),
                            Tapped = Convert.ToBoolean(boxtapped.Text),
                            ID_Karty = Convert.ToInt32(BoxID_Karty.Text)
                        };
                        se.Mana.Add(n3);
                        se.SaveChanges();
                    }
                    if (!string.IsNullOrWhiteSpace(boxidplans.Text))
                    {
                        var n4 = new Planeswalker
                        {
                            ID_Planeswalker = Convert.ToInt32(boxidplans.Text),
                            Punkty_Lojalnosci = Convert.ToInt32(boxpunktloaj.Text),
                            ID_Karty = Convert.ToInt32(BoxID_Karty.Text)
                        };
                        se.Planeswalker.Add(n4);
                        se.SaveChanges();
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            BoxID_Karty.Clear();
            BoxNazwa_Karty.Clear();
            BoxKoszt.Clear();
            BoxTyp.Clear();
            BoxEdycja.Clear();
            BoxOpis.Clear();
            BoxRok.Clear();
            BoxAutor_Grafiki.Clear();
            boxidkreatury.Clear();
            boxatak.Clear();
            boxobrona.Clear();
            boxidmany.Clear();
            boxtapped.Clear();
            boxidplans.Clear();
            boxpunktloaj.Clear();
        }
        private void BoxID_Karty_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void Przycisk_Dodaj_Talie_Click_1(object sender, EventArgs e)
        {
            using (PBDKarty.Kartyv1Entities se = new Kartyv1Entities())
            {
                try
                {
                    var newInstructor = new Talia
                    {
                        ID_Talii = Convert.ToInt32(BoxID_Talii.Text),
                        Nazwa_Talii = BoxNazwa_Talii.Text,
                        Ilosc_Kart = Convert.ToInt32(BoxIlosc_Kart.Text)
                    };
                    se.Talia.Add(newInstructor);
                    se.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            BoxID_Talii_T.Clear();
            BoxNazwa_Talii.Clear();
            BoxIlosc_Kart.Clear();
        }







        private void BazaDanych_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BoxIDGracz_TextChanged(object sender, EventArgs e)
        {

            ID = BoxIDGracza.Text;
        }

        private void BoxData_Dolaczenia_TextChanged(object sender, EventArgs e)
        {
            Data_Dolaczenia = BoxData_Dolaczenia.Text;
        }

        private void BoxData_Urodzin_TextChanged(object sender, EventArgs e)
        {
            Data_Urodzenia = BoxData_Urodzin.Text;
        }
        private void BoxID_Gracza_S_TextChanged(object sender, EventArgs e)
        {
            id_Gracza = BoxID_Gracza_S.Text;
        }

        private void Przycisk_Wczytaj_K_Click(object sender, EventArgs e)
        {
            using (PBDKarty.Kartyv1Entities se = new Kartyv1Entities())
            {

                try
                {
                    int ww = 0;
                    var odKarty1 = from x in se.Karty
                                   join y in se.Mana on x.ID_Karty equals y.ID_Karty into nowa1
                                   from z in nowa1.DefaultIfEmpty()
                                   select new
                                   {
                                       x.ID_Karty,
                                       x.Nazwa_Karty,
                                       x.Koszt,
                                       x.Typ,
                                       x.Edycja,
                                       x.Opis,
                                       x.Rok,
                                       x.Autor_Grafiki,
                                       Tapped = (z == null ? false : z.Tapped),
                                       ID_Mana = (z == null ? ww : z.ID_Mana)
                                   };

                    var odKarty2 = from q in odKarty1
                                   join w in se.Kreatury on q.ID_Karty equals w.ID_Karty into nowa2
                                   from r in nowa2.DefaultIfEmpty()
                                   select new
                                   {
                                       q.ID_Karty,
                                       q.Nazwa_Karty,
                                       q.Koszt,
                                       q.Typ,
                                       q.Edycja,
                                       q.Opis,
                                       q.Rok,
                                       q.Autor_Grafiki,
                                       q.Tapped,
                                       q.ID_Mana,
                                       ID_Kreatury = (r == null ? ww : r.ID_Kreatury),
                                       Atak = (r == null ? ww : r.Atak),
                                       Obrona = (r == null ? ww : r.Obrona)
                                   };
                    var odKarty3 = from a in odKarty2
                                   join s in se.Planeswalker on a.ID_Karty equals s.ID_Karty into nowa3
                                   from d in nowa3.DefaultIfEmpty()
                                   select new
                                   {
                                       a.ID_Karty,
                                       a.Nazwa_Karty,
                                       a.Koszt,
                                       a.Typ,
                                       a.Edycja,
                                       a.Opis,
                                       a.Rok,
                                       a.Autor_Grafiki,
                                       a.ID_Kreatury,
                                       a.Atak,
                                       a.Obrona,
                                       ID_Planeswalker = (d == null ? ww : d.ID_Planeswalker),
                                       Punkty_Lojalnosci = (d == null ? ww : d.Punkty_Lojalnosci),
                                       a.ID_Mana,
                                       a.Tapped
                                   };
                    if (!string.IsNullOrWhiteSpace(odidkartyk.Text))
                    {
                        odkartyID = Convert.ToInt32(odidkartyk.Text);
                        odKarty3 = odKarty3.Where(q => (Int32)q.ID_Karty == odkartyID);
                    }
                    if (!string.IsNullOrWhiteSpace(odnazwakartyk.Text))
                    {
                        odnazwakarty = Convert.ToString(odnazwakartyk.Text);
                        odKarty3 = odKarty3.Where(q => (String)q.Nazwa_Karty == odnazwakarty);
                    }
                    if (!string.IsNullOrWhiteSpace(odkoszt.Text))
                    {
                        odkosztk = Convert.ToString(odkoszt.Text);
                        odKarty3 = odKarty3.Where(q => (String)q.Koszt == odkosztk);
                    }
                    if (!string.IsNullOrWhiteSpace(odtyp.Text))
                    {
                        odtypk = Convert.ToString(odtyp.Text);
                        odKarty3 = odKarty3.Where(q => (String)q.Typ == odtypk);
                    }
                    if (!string.IsNullOrWhiteSpace(odedycja.Text))
                    {
                        odedycjak = Convert.ToString(odedycja.Text);
                        odKarty3 = odKarty3.Where(q => (String)q.Edycja == odedycjak);
                    }
                    if (!string.IsNullOrWhiteSpace(odopis.Text))
                    {
                        odopisk = Convert.ToString(odopis.Text);
                        odKarty3 = odKarty3.Where(q => (String)q.Opis == odopisk);
                    }
                    if (!string.IsNullOrWhiteSpace(odRok.Text))
                    {
                        odrokk = Convert.ToInt32(odRok.Text);
                        odKarty3 = odKarty3.Where(q => (Int32)q.Rok == odrokk);
                    }
                    if (!string.IsNullOrWhiteSpace(odautorgrafiki.Text))
                    {
                        odautorgrafikik = Convert.ToString(odautorgrafiki.Text);
                        odKarty3 = odKarty3.Where(q => (String)q.Autor_Grafiki == odautorgrafikik);
                    }
                    if (!string.IsNullOrWhiteSpace(odidkreatury.Text))
                    {
                        odkreaturyID = Convert.ToInt32(odidkreatury.Text);
                        odKarty3 = odKarty3.Where(q => (Int32)q.ID_Kreatury == odkreaturyID);
                    }
                    if (!string.IsNullOrWhiteSpace(odatak.Text))
                    {
                        odatakk = Convert.ToInt32(odatak.Text);
                        odKarty3 = odKarty3.Where(q => (Int32)q.Atak == odatakk);
                    }
                    if (!string.IsNullOrWhiteSpace(odobrona.Text))
                    {
                        odobronak = Convert.ToInt32(odobrona.Text);
                        odKarty3 = odKarty3.Where(q => (Int32)q.Obrona == odobronak);
                    }
                    if (!string.IsNullOrWhiteSpace(odidplanse.Text))
                    {
                        odplansewalkerid = Convert.ToInt32(odidplanse.Text);
                        odKarty3 = odKarty3.Where(q => (Int32)q.ID_Planeswalker == odplansewalkerid);
                    }
                    if (!string.IsNullOrWhiteSpace(odpunktyloj.Text))
                    {
                        odpunktylojk = Convert.ToInt32(odpunktyloj.Text);
                        odKarty3 = odKarty3.Where(q => (Int32)q.Punkty_Lojalnosci == odpunktylojk);
                    }
                    if (!string.IsNullOrWhiteSpace(odidmana.Text))
                    {
                        odmanyid = Convert.ToInt32(odidmana.Text);
                        odKarty3 = odKarty3.Where(q => (Int32)q.ID_Mana == odmanyid);
                    }
                    if (!string.IsNullOrWhiteSpace(odtapped.Text))
                    {
                        odtappedk = Convert.ToBoolean(odtapped.Text);
                        odKarty3 = odKarty3.Where(q => (Boolean)q.Tapped == odtappedk);
                    }
                    odKarty.DataSource = odKarty3.ToArray();
                    odidkartyk.Clear();
                    odnazwakartyk.Clear();
                    odkoszt.Clear();
                    odtyp.Clear();
                    odedycja.Clear();
                    odopis.Clear();
                    odRok.Clear();
                    odautorgrafiki.Clear();
                    odidkreatury.Clear();
                    odatak.Clear();
                    odobrona.Clear();
                    odidplanse.Clear();
                    odpunktyloj.Clear();
                    odidmana.Clear();
                    odtapped.Clear();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }



            }
        }

        private void BoxID_Statystyki_TextChanged(object sender, EventArgs e)
        {
            id_Statystyki = BoxID_Statystyki.Text;
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void Przycisk_Wczytaj_T_Click(object sender, EventArgs e)
        {
            using (PBDKarty.Kartyv1Entities se = new Kartyv1Entities())
            {

                try
                {
                    var odTalie1 = from x in se.Karty_Talia
                                   join y in se.Karty on x.ID_Karty equals y.ID_Karty into nowa
                                   from z in nowa.DefaultIfEmpty()
                                   select new
                                   {
                                       x.ID_K_T,
                                       x.ID_Talii,
                                       z.Nazwa_Karty,
                                       x.Ilosc_Sztuk
                                   };

                    var odTalie2 = from q in odTalie1
                                   join w in se.Talia on q.ID_Talii equals w.ID_Talii into nowa2
                                   from r in nowa2.DefaultIfEmpty()
                                   select new
                                   {
                                       q.ID_K_T,
                                       q.Nazwa_Karty,
                                       r.Nazwa_Talii,
                                       q.Ilosc_Sztuk
                                   };
                    if (!string.IsNullOrWhiteSpace(odidpisu.Text))
                    {
                        odtID = Convert.ToInt32(odidpisu.Text);
                        odTalie2 = odTalie2.Where(q => (Int32)q.ID_K_T == odtID);
                    }
                    if (!string.IsNullOrWhiteSpace(odnazwakartyt.Text))
                    {
                        odnazwa_kartyt = Convert.ToString(odnazwakartyt.Text);
                        odTalie2 = odTalie2.Where(q => (String)q.Nazwa_Karty == odnazwa_kartyt);
                    }
                    if (!string.IsNullOrWhiteSpace(odnazwatalit.Text))
                    {
                        odnazwa_taliit = Convert.ToString(odnazwatalit.Text);
                        odTalie2 = odTalie2.Where(q => (String)q.Nazwa_Talii == odnazwa_taliit);
                    }
                    if (!string.IsNullOrWhiteSpace(odiloscsztuk.Text))
                    {
                        odiloscsztukt = Convert.ToInt32(odiloscsztuk.Text);
                        odTalie2 = odTalie2.Where(q => (Int32)q.Ilosc_Sztuk == odiloscsztukt);
                    }
                    OdczytTalii.DataSource = odTalie2.ToArray();
                    odidpisu.Clear();
                    odnazwakartyt.Clear();
                    odnazwatalit.Clear();
                    odiloscsztuk.Clear();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }



            }
        }

        private void BoxID_Karty_TextChanged(object sender, EventArgs e)
        {
            id_Karty = BoxID_Karty.Text;
        }

        private void BoxNazwa_Karty_TextChanged(object sender, EventArgs e)
        {
            nazwa_Karty = BoxNazwa_Karty.Text;
        }

        private void BoxID_Talii_T_TextChanged(object sender, EventArgs e)
        {
            id_talii_t = BoxID_Talii_T.Text;
        }

        private void Przycisk_Wczytaj_S_Click(object sender, EventArgs e)
        {
            using (PBDKarty.Kartyv1Entities se = new Kartyv1Entities())
            {

                try
                {
                    var odStatystyki = from x in se.Statystyka
                                       join y in se.Gracz on x.ID_Gracza equals y.ID_Gracza into nowa
                                       from z in nowa.DefaultIfEmpty()
                                       select new
                                       {
                                           x.ID_Statystyki,
                                           x.ID_Gracza,
                                           z.E_mail,
                                           x.Wygrane,
                                           x.Przegrane,
                                           x.Remisy
                                       };
                    if (!string.IsNullOrWhiteSpace(odidstat.Text))
                    {
                        odsID = Convert.ToInt32(odidstat.Text);
                        odStatystyki = odStatystyki.Where(x => (Int32)x.ID_Statystyki == odsID);
                    }
                    if (!string.IsNullOrWhiteSpace(odidgracza_s.Text))
                    {
                        odgIDs = Convert.ToInt32(odidgracza_s.Text);
                        odStatystyki = odStatystyki.Where(x => (Int32)x.ID_Gracza == odgIDs);
                    }
                    if (!string.IsNullOrWhiteSpace(odemail_s.Text))
                    {
                        ode_mails = Convert.ToString(odemail_s.Text);
                        odStatystyki = odStatystyki.Where(z => (String)z.E_mail == ode_mails);
                    }
                    if (!string.IsNullOrWhiteSpace(odwygrane.Text))
                    {
                        odwygranes = Convert.ToInt32(odwygrane.Text);
                        odStatystyki = odStatystyki.Where(x => (Int32)x.Wygrane == odwygranes);
                    }
                    if (!string.IsNullOrWhiteSpace(odprzegrane.Text))
                    {
                        odprzegranes = Convert.ToInt32(odprzegrane.Text);
                        odStatystyki = odStatystyki.Where(x => (Int32)x.Przegrane == odprzegranes);
                    }
                    if (!string.IsNullOrWhiteSpace(odremisy.Text))
                    {
                        odremisys = Convert.ToInt32(odremisy.Text);
                        odStatystyki = odStatystyki.Where(x => (Int32)x.Remisy == odremisys);
                    }
                    OdczytStatystyki.DataSource = odStatystyki.ToArray();
                    odidstat.Clear();
                    odidgracza_s.Clear();
                    odemail_s.Clear();
                    odwygrane.Clear();
                    odprzegrane.Clear();
                    odremisy.Clear();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }



            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxNazwa_Talii_TextChanged(object sender, EventArgs e)
        {
            nazwa_Talii = BoxNazwa_Talii.Text;
        }

        private void BoxIlosc_Kart_TextChanged(object sender, EventArgs e)
        {
            ilosc_Kart = BoxIlosc_Kart.Text;
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void BoxID_Talii_TextChanged(object sender, EventArgs e)
        {
            id_Talii = BoxID_Talii.Text;
        }



        private void BoxKoszt_TextChanged(object sender, EventArgs e)
        {
            koszt = BoxKoszt.Text;
        }

        private void BoxTyp_TextChanged(object sender, EventArgs e)
        {
            typ = BoxTyp.Text;
        }

        private void BoxEdycja_TextChanged(object sender, EventArgs e)
        {
            edycja = BoxEdycja.Text;
        }

        private void BoxOpis_TextChanged(object sender, EventArgs e)
        {
            opis = BoxOpis.Text;
        }

        private void BoxRok_TextChanged(object sender, EventArgs e)
        {
            rok = BoxRok.Text;
        }

        private void BoxAutor_Grafiki_TextChanged(object sender, EventArgs e)
        {
            autor_Grafiki = BoxAutor_Grafiki.Text;
        }



        private void BoxWygrane_TextChanged(object sender, EventArgs e)
        {
            wygrane = BoxWygrane.Text;
        }

        private void BoxPrzegrane_TextChanged(object sender, EventArgs e)
        {
            przegrane = BoxPrzegrane.Text;
        }

        private void BoxRemisy_TextChanged(object sender, EventArgs e)
        {
            remisy = BoxRemisy.Text;
        }



        private void BoxE_mail_TextChanged(object sender, EventArgs e)
        {
            E_mail = BoxE_mail.Text;
        }


        private void Przycisk_WczytajG_Click(object sender, EventArgs e)
        {
            using (PBDKarty.Kartyv1Entities se = new Kartyv1Entities())
            {

                try
                {
                    var odGracz = from x in se.Gracz
                                  join y in se.Talia on x.ID_Talii equals y.ID_Talii into nowa
                                  from z in nowa.DefaultIfEmpty()
                                  select new
                                  {
                                      x.ID_Gracza,
                                      x.Data_Dolaczenia,
                                      x.Data_Urodzin,
                                      x.E_mail,
                                      z.Nazwa_Talii
                                  };

                    if (!string.IsNullOrWhiteSpace(odidgracz.Text))
                    {
                        odgID = Convert.ToInt32(odidgracz.Text);
                        odGracz = odGracz.Where(x => (Int32)x.ID_Gracza == odgID);
                    }
                    if (!string.IsNullOrWhiteSpace(oddatadolaczenia.Text))
                    {
                        oddata_dolaczenia = Convert.ToDateTime(oddatadolaczenia.Text);
                        odGracz = odGracz.Where(x => (DateTime)x.Data_Dolaczenia == oddata_dolaczenia);
                    }
                    if (!string.IsNullOrWhiteSpace(oddataurodzin.Text))
                    {
                        oddata_urodzin = Convert.ToDateTime(oddataurodzin.Text);
                        odGracz = odGracz.Where(x => (DateTime)x.Data_Urodzin == oddata_urodzin);
                    }
                    if (!string.IsNullOrWhiteSpace(odemail.Text))
                    {
                        ode_mail = Convert.ToString(odemail.Text);
                        odGracz = odGracz.Where(x => (String)x.E_mail == ode_mail);
                    }
                    if (!string.IsNullOrWhiteSpace(odnazwatalii.Text))
                    {
                        odnazwa_talii = Convert.ToString(odnazwatalii.Text);
                        odGracz = odGracz.Where(z => (String)z.Nazwa_Talii == odnazwa_talii);
                    }
                    OdczytGracz.DataSource = odGracz.ToArray();
                    odidgracz.Clear();
                    oddatadolaczenia.Clear();
                    oddataurodzin.Clear();
                    odemail.Clear();
                    odnazwatalii.Clear();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }



            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}


