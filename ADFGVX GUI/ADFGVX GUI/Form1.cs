using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADFGVX_GUI
{
    public partial class Form1 : Form
    {
        public enum Indexy
        {
            A = 0,
            D = 1,
            F = 2,
            G = 3,
            V = 4,
            X = 5,                
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnCrypt_Click(object sender, EventArgs e)
        {
            textBoxOutputEnCryptText.Clear();
            textBoxTable.Clear();
            EnCrypt();

        }

        private void buttonDeCrypt_Click(object sender, EventArgs e)
        {
            textBoxOutputDeCryptText.Clear();
            textBoxTable.Clear();
            DeCrypt();

        }     
        private void DeCrypt()
        {
            char[] zdrojovaAbeceda = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
                'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0','1','2','3','4','5','6','7','8','9' };

            string klic = textBoxDecryptSubKey.Text.ToUpper();
            string klic2 = textBoxDecryptPermKey.Text.ToUpper();
            char[] klic2Arr = klic2.ToArray();

            string sifra = textBoxInputCryptedText.Text.ToUpper();
            char[] sifraArr = sifra.ToCharArray();

            int pocetSloupcu = klic2.Length;
            double pocetRadku = Math.Ceiling((double)sifraArr.Length / pocetSloupcu);

            //Vytvoreni neusporadane tabulkdy z retezce sifra
            char[,] tabulka1 = new char[(int)pocetRadku, pocetSloupcu];

            int cntr1 = 0;
            for (int sloupec = 0; sloupec < pocetSloupcu; sloupec++)
            {
                for (int radek = 0; radek < pocetRadku; radek++)
                {
                    if (cntr1 < sifraArr.Length)
                    {
                        tabulka1[radek, sloupec] = sifraArr[cntr1++];
                    }
                    else
                    {
                        tabulka1[radek, sloupec] = '\0';
                    }


                }

            }          

            // Serazeni tabulky podle klice
            int[] klic2intArr = new int[klic2.Length];
            for (int i = 0; i < klic2.Length; i++)
            {
                klic2intArr[i] = (int)klic2Arr[i];
            }
            Array.Sort(klic2intArr);

            char[] klic2ArrSrt = new char[klic2.Length];

            for (int i = 0; i < klic2.Length; i++)
            {
                klic2ArrSrt[i] = (char)klic2intArr[i];
            }


            char[,] tabulka2 = new char[(int)pocetRadku, pocetSloupcu];
            for (int SortPos = 0; SortPos < klic2.Length; SortPos++)
            {
                for (int UnsortPos = 0; UnsortPos < klic2.Length; UnsortPos++)
                {
                    if (klic2ArrSrt[SortPos] == klic2Arr[UnsortPos])
                    {
                        for (int radek = 0; radek < pocetRadku; radek++)
                        {
                            tabulka2[radek, UnsortPos] = tabulka1[radek, SortPos];

                        }

                    }
                }

            }

            //Vytvoreni sifrovaci tabulky
            char[] klicArray = klic.ToCharArray();
            char[] novyKlicArr = new char[klic.Length];
            char[] buffer = new char[klic.Length];
            buffer[0] = klicArray[0];
            novyKlicArr[0] = klicArray[0];
            for (int i = 0; i < klic.Length; i++)
            {
                if (i != 0)
                {
                    if (IsLetterContained(klicArray[i], buffer))
                    {
                    }
                    else
                    {
                        buffer[i] = klicArray[i];
                        novyKlicArr[i] = klicArray[i];
                    }
                }
            }

            string novyKlic = new string(novyKlicArr);


            char[] znakyDoTabulky = new char[zdrojovaAbeceda.Length];
            int cntr = 0;
            foreach (char c in novyKlic)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    znakyDoTabulky[cntr++] = c;
                }
            }
            int odsazeni = 0;

            for (int i = 0; i < zdrojovaAbeceda.Length; i++)
            {
                if (IsLetterContained(zdrojovaAbeceda[i], znakyDoTabulky))
                {
                    odsazeni++;
                }
                else
                {
                    if (Char.IsLetterOrDigit(zdrojovaAbeceda[i]))
                    {
                        znakyDoTabulky[i + cntr - odsazeni] = zdrojovaAbeceda[i];
                    }


                }

            }

            char[,] tabulka = new char[6, 6];

            int cnt2 = 0;
            for (int radek = 0; radek < 6; radek++)
            {
                for (int sloupec = 0; sloupec < 6; sloupec++)
                {
                    tabulka[radek, sloupec] = znakyDoTabulky[cnt2++];


                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    textBoxTable.Text += Convert.ToString(tabulka[i, j]);
                    textBoxTable.Text += "\t";

                }
                textBoxTable.Text += Environment.NewLine;
            }



            char[] sifraArrSort = new char[sifra.Length];
            int cntr2 = 0;
            for (int radek = 0; radek < pocetRadku; radek++)
            {
                for (int sloupec = 0; sloupec < pocetSloupcu; sloupec++)
                {
                    if (tabulka2[radek, sloupec] !='\0')
                    {
                        sifraArrSort[cntr2++] = tabulka2[radek, sloupec];
                    }
                }


            }

            List<char[]> arrayList = new List<char[]>();


            for (int i = 0; i < sifraArrSort.Length / 2; i++)
            {
                char[] dvaznaky = new char[2];
                for (int j = 1; j < 3; j++)
                {
                    if (i == 0)
                    {
                        dvaznaky[j - 1] = sifraArrSort[i + j - 1];

                    }
                    else
                    {
                        if (j == 1)
                        {
                            dvaznaky[j - 1] = sifraArrSort[i * j * 2];
                        }
                        else if (j == 2)
                        {
                            dvaznaky[j - 1] = sifraArrSort[i * j + 1];
                        }

                    }
                }
                arrayList.Add(dvaznaky);
            }




            List<int[]> listIndexy = new List<int[]>();

            for (int i = 0; i < arrayList.Count; i++)
            {
                int[] souradnice = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    switch (arrayList[i][j])
                    {
                        case 'A':
                            souradnice[j] = (int)Indexy.A;
                            break;
                        case 'D':
                            souradnice[j] = (int)Indexy.D;
                            break;
                        case 'F':
                            souradnice[j] = (int)Indexy.F;
                            break;
                        case 'G':
                            souradnice[j] = (int)Indexy.G;
                            break;
                        case 'V':
                            souradnice[j] = (int)Indexy.V;
                            break;
                        case 'X':
                            souradnice[j] = (int)Indexy.X;
                            break;

                    }

                }
                listIndexy.Add(souradnice);


            }



            char[] deSifrovaneSlovoArr = new char[sifra.Length / 2];
            int cntr3 = 0;
            foreach (var item in listIndexy)
            {
                deSifrovaneSlovoArr[cntr3++] = tabulka[item[0], item[1]];

            }

            foreach (char c in deSifrovaneSlovoArr)
            {
                textBoxOutputDeCryptText.Text += c;
            }
        }

        private void EnCrypt()
        {
            string klic = textBoxEncryptSubKey.Text.ToUpper();
            char[] zdrojovaAbeceda = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L','M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0','1','2','3','4','5','6','7','8','9' };
            char[] klicArray = klic.ToCharArray();
            char[] novyKlicArr = new char[klic.Length];
            char[] buffer = new char[klic.Length];
            buffer[0] = klicArray[0];
            novyKlicArr[0] = klicArray[0];
            for (int i = 0; i < klic.Length; i++)
            {
                if (i != 0)
                {
                    if (IsLetterContained(klicArray[i], buffer))
                    {
                    }
                    else
                    {
                        buffer[i] = klicArray[i];
                        novyKlicArr[i] = klicArray[i];
                    }
                }
            }

            string novyKlic = new string(novyKlicArr);

            //Vytvoreni sifrovaci tabulky

            char[] znakyDoTabulky = new char[zdrojovaAbeceda.Length];
            int cntr = 0;
            foreach (char c in novyKlic)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    znakyDoTabulky[cntr++] = c;
                }
            }
            int odsazeni = 0;

            for (int i = 0; i < zdrojovaAbeceda.Length; i++)
            {
                if (IsLetterContained(zdrojovaAbeceda[i], znakyDoTabulky))
                {
                    odsazeni++;
                }
                else
                {
                    if (Char.IsLetterOrDigit(zdrojovaAbeceda[i]))
                    {
                        znakyDoTabulky[i + cntr - odsazeni] = zdrojovaAbeceda[i];
                    }


                }

            }

            char[,] tabulka = new char[6, 6];

            int cnt2 = 0;
            for (int radek = 0; radek < 6; radek++)
            {
                for (int sloupec = 0; sloupec < 6; sloupec++)
                {
                    tabulka[radek, sloupec] = znakyDoTabulky[cnt2++];


                }
            }

            string vstup = textBoxInputPlainText.Text.ToUpper();
            vstup = vstup.Trim();
            char[] vstupArr = vstup.ToLower().ToCharArray();
            for (int i = 0; i < vstupArr.Length; i++)
            {
                if (Char.IsLetter(vstupArr[i]))
                {
                    if (vstupArr[i] == 'ě')
                    {
                        vstupArr[i] = 'E';
                    }
                    if (vstupArr[i] == 'š')
                    {
                        vstupArr[i] = 'S';
                    }
                    if (vstupArr[i] == 'č')
                    {
                        vstupArr[i] = 'C';
                    }
                    if (vstupArr[i] == 'ř')
                    {
                        vstupArr[i] = 'R';
                    }
                    if (vstupArr[i] == 'ž')
                    {
                        vstupArr[i] = 'Z';
                    }
                    if (vstupArr[i] == 'ý')
                    {
                        vstupArr[i] = 'Y';
                    }
                    if (vstupArr[i] == 'á')
                    {
                        vstupArr[i] = 'A';
                    }
                    if (vstupArr[i] == 'í')
                    {
                        vstupArr[i] = 'I';
                    }
                    if (vstupArr[i] == 'é')
                    {
                        vstupArr[i] = 'E';
                    }
                    if (vstupArr[i] == 'ů')
                    {
                        vstupArr[i] = 'U';
                    }
                    if (vstupArr[i] == 'ď')
                    {
                        vstupArr[i] = 'D';
                    }
                    if (vstupArr[i] == 'ň')
                    {
                        vstupArr[i] = 'N';
                    }
                    if (vstupArr[i] == 'ó')
                    {
                        vstupArr[i] = 'O';
                    }
                    if (vstupArr[i] == 'ť')
                    {
                        vstupArr[i] = 'T';
                    }
                    if (vstupArr[i] == 'ú')
                    {
                        vstupArr[i] = 'U';
                    }
                    if (vstupArr[i] == 'q')
                    {
                        vstupArr[i] = 'K';
                    }
                }


            }
            string slovo = new string(vstupArr);
            slovo = slovo.ToUpper();


            char[] slovoArr = slovo.ToCharArray();


            // Prvni cast sifrovani
            List<char[]> prvniCastCryptList = new List<char[]>();


            for (int znak = 0; znak < slovo.Length; znak++)
            {
                char[] prvniCastCrypt = new char[2];
                for (int radek = 0; radek < 6; radek++)
                {
                    for (int sloupec = 0; sloupec < 6; sloupec++)
                    {
                        if (slovo[znak] == tabulka[radek, sloupec])
                        {
                            switch (radek)
                            {
                                case (int)Indexy.A:
                                    prvniCastCrypt[0] = 'A';
                                    break;
                                case (int)Indexy.D:
                                    prvniCastCrypt[0] = 'D';
                                    break;
                                case (int)Indexy.F:
                                    prvniCastCrypt[0] = 'F';
                                    break;
                                case (int)Indexy.G:
                                    prvniCastCrypt[0] = 'G';
                                    break;
                                case (int)Indexy.V:
                                    prvniCastCrypt[0] = 'V';
                                    break;
                                case (int)Indexy.X:
                                    prvniCastCrypt[0] = 'X';
                                    break;
                            }
                            switch (sloupec)
                            {
                                case (int)Indexy.A:
                                    prvniCastCrypt[1] = 'A';
                                    break;
                                case (int)Indexy.D:
                                    prvniCastCrypt[1] = 'D';
                                    break;
                                case (int)Indexy.F:
                                    prvniCastCrypt[1] = 'F';
                                    break;
                                case (int)Indexy.G:
                                    prvniCastCrypt[1] = 'G';
                                    break;
                                case (int)Indexy.V:
                                    prvniCastCrypt[1] = 'V';
                                    break;
                                case (int)Indexy.X:
                                    prvniCastCrypt[1] = 'X';
                                    break;
                            }
                        }
                    }
                }
                prvniCastCryptList.Add(prvniCastCrypt);
            }

            /*
            foreach (var vr in prvniCastCryptList)
            {
                foreach (var v in vr)
                {
                    Console.Write(v);
                }
            }
            Console.WriteLine();
            */







            char[] prvniCastZnaky = new char[prvniCastCryptList.Count * 2];

            for (int i = 0; i < prvniCastCryptList.Count; i++)
            {
                char[] dvaznaky = prvniCastCryptList[i];
                for (int j = 1; j < 3; j++)
                {
                    if (i == 0)
                    {
                        prvniCastZnaky[j - 1] = dvaznaky[j - 1];

                    }
                    else
                    {
                        if (j == 1)
                        {
                            prvniCastZnaky[i * j * 2] = dvaznaky[j - 1];
                        }
                        else if (j == 2)
                        {
                            prvniCastZnaky[i * j + 1] = dvaznaky[j - 1];
                        }

                    }
                }
            }
            /*
            foreach (var v in prvniCastZnaky)
            {
                Console.Write(v);
            }
            Console.WriteLine();
            */




            // druha cast sifrovani
            string klic2 = textBoxEncryptPermKey.Text.ToUpper();
            char[] klic2Arr = klic2.ToCharArray();
            int[] poradiSloupcu = new int[klic2.Length];


            double pocetRadku = Math.Ceiling((double)prvniCastCryptList.Count * 2 / klic2.Length);
            int pocetSloupcu = klic2.Length;
            //
            char[,] tabulka2 = new char[(int)pocetRadku, pocetSloupcu];
            int cntr3 = 0;
            for (int radek = 0; radek < pocetRadku; radek++)
            {
                for (int sloupec = 0; sloupec < pocetSloupcu; sloupec++)
                {
                    if(cntr3<prvniCastZnaky.Length)
                    {
                        tabulka2[radek, sloupec] = prvniCastZnaky[cntr3++];
                    }
                    else
                    {
                        tabulka2[radek, sloupec] = '\0';
                    }
                }

            }


            int[] klic2intArr = new int[klic2.Length];
            for (int i = 0; i < klic2.Length; i++)
            {
                klic2intArr[i] = (int)klic2Arr[i];
            }
            Array.Sort(klic2intArr);

            char[] klic2ArrSrt = new char[klic2.Length];

            for (int i = 0; i < klic2.Length; i++)
            {
                klic2ArrSrt[i] = (char)klic2intArr[i];
            }

            //transpose

            char[,] tabulka3 = new char[(int)pocetRadku, pocetSloupcu];
            for (int SortPos = 0; SortPos < klic2.Length; SortPos++)
            {
                for (int UnsortPos = 0; UnsortPos < klic2.Length; UnsortPos++)
                {
                    if (klic2ArrSrt[SortPos] == klic2Arr[UnsortPos])
                    {
                        for (int radek = 0; radek < pocetRadku; radek++)
                        {
                            tabulka3[radek, SortPos] = tabulka2[radek, UnsortPos];

                        }

                    }
                }

            }

            int cnt4 = 0;
            char[] zasifrovanyCharArr = new char[vstup.Length * 2];
            for (int sloupec = 0; sloupec < pocetSloupcu; sloupec++)
            {
                for (int radek = 0; radek < pocetRadku; radek++)
                {
                    if (tabulka3[radek, sloupec] != '\0')
                    {
                        zasifrovanyCharArr[cnt4++] = tabulka3[radek, sloupec];
                    }


                }

            }



            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    textBoxTable.Text += Convert.ToString(tabulka[i, j]);
                    textBoxTable.Text += "\t";

                }
                textBoxTable.Text += Environment.NewLine;
            }
            /*
            Console.WriteLine();

            for (int i = 0; i < pocetRadku; i++)
            {
                for (int j = 0; j < pocetSloupcu; j++)
                {
                    Console.Write(tabulka2[i, j] + " ");

                }
                Console.Write("\n");
            }
            Console.WriteLine();
            */
            /*
            for (int i = 0; i < pocetRadku; i++)
            {
                for (int j = 0; j < pocetSloupcu; j++)
                {
                    Console.Write(tabulka3[i, j] + " ");

                }
                Console.Write("\n");
            }
            Console.WriteLine();
            */

            foreach (var v in zasifrovanyCharArr)
            {
                textBoxOutputEnCryptText.Text += v;
                
            }
            /*
            Console.WriteLine();
            Console.WriteLine();
            */



        }


        static bool IsLetterContained(char c, char[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                if (c == buffer[i])
                {
                    return true;

                }
            }
            return false;
        }

        private void textBoxEncryptSubKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}









/*
 * Použijte šifru ADFG(V)X, používanou během 1. světové války. Tato šifra funguje na následujícím principu:

Vygenerujete si náhodnou abecedu A-Z a uspořádáte ji do matice 5x5. Všechna písmena se vám do matice nevejdou, z tohoto důvodu budete nahrazovat J -> I nebo W -> V.

Jednotlivým řádkům a sloupcům přiřadíme indexy pomocí znaků A,D,F,G,X

Každý znak otevřeného textu nahradíme řádkovým a sloupcovým indexem  vybraneho znaku z vygenerované šifrovací tabulky, tzn. každý znak bude v šifrovaném textu představovat dvojici znaků.  

V dalším kroku použijete zadané klíčové slovo, pomocí kterého bude probíhat transformace sloupců v matici.

Zjistíte si délku klíčového slova a podle toho rozdělíte šifrovaný text do řádků.

Klíčové slovo zeřadíte dle abecedy spolu s příslušnými sloupci šifrovaného textu.

Po sloupcích přepíšeme zašifrovaný text.

Dešifrování probíhá inverzním způsobem. Tabulku jste generovali náhodně, proto musíte použít stejnou tabulku na dešifrování.  

Implementujte obě varianty tj. ADFGX a ADFGVX. Rozdíl spočívá pouze ve velikosti matice, tzn. že u varianty ADFGVX použijete matici 6x6.

Popis šifry si můžete najít např. na https://en.wikipedia.org/wiki/ADFGVX_cipher.

Tento úkol je hodnocený a jeho správné, včasné a samostatné vypracování je podmínkou pro získání zápočtu.

Celkem můžete získat 10 bodů.

1b za správnou filtraci vstupních dat (Jak jsme zvyklí z předchozích šífer, zachování mezer)

1b za funkci pro vygenerování náhodné abecedy pro ADFG(V)X

1b za funkci pro ADFGX šifrování

1b za funkci pro ADFGVX šifrování

1b za funkci pro ADFGX dešifrování

1b za funkci pro ADFGVX dešifrování

4b za uživatelské rozhraní, které bude obsahovat pole pro zadání textu pro šifrování a dešifrování, pro zadání klíče,
pro zadání šifrovací matice ručně (spolu s vyřazováním nebo znázorněních zbývajících znaků pro vyplnění),
výpis zašifrovaného textu (mezeru dle sloupců), výpis aktuální šifrovací tabulky,
tlačítko pro volbu šifrování dešifrování v rámci stejného GUI, přepínač pro volbu verze ADFGX (CZ/EN verze u 5x5) a ADFGVX šifry,
přepínač pro volbu zadání matice a náhodného generování.

Bodování je opět orientační a může se měnit na základě kvality !!!
*/