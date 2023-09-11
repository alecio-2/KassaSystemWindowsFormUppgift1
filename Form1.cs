using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaSystemWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Metod för att räkna ut rest
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Deklarera variabler för köpbelopp (tal1) och betalningssumma (tal2)
            int tal1 = Convert.ToInt32(tal1Value.Text);
            int tal2 = Convert.ToInt32(tal2Value.Text);

            // Kontrollera om köpbeloppet är större än betalningssumma
            if (tal1 > tal2)
            {
                // Medella om pengarna räcker inte
                restResultat.Text = "Betalningssuman är otillräcklig!";
            }
            else
            {
                // Beräkna växel
                int rest = tal2 - tal1;
                restResultat.Text = "Växel tillbaka:" + rest + "\n";

                // Beräkna och visa växel i sedlar och mynt
                calculateRest(ref rest, 500, "femhundralapp", "femhundralappar");
                calculateRest(ref rest, 200, "tvåhundralapp", "tvåhundralappar");
                calculateRest(ref rest, 100, "hundralapp", "hundralappar");
                calculateRest(ref rest, 50, "femtiolapp", "femtiolappar");
                calculateRest(ref rest, 20, "tjugolapp", "tjugolappar");
                calculateRest(ref rest, 10, "tia", "tior");
                calculateRest(ref rest, 5, "femma", "femmor");
                calculateRest(ref rest, 1, "etta", "ettor");

                // En metod för att beräkna och visa växel i olika valörer
                void calculateRest(ref int restchange, int denomination, string singular, string plural)
                {
                    // Beräkna hur många av valören (denomination) som ryms i restväxeln
                    int numDenomination = rest / denomination;
                    // Om det finns minst en av valören i restväxeln
                    if (numDenomination > 0)
                    {
                        // Uppdatera restväxeln genom att ta bort det belopp som täcks av valören
                        restchange %= denomination;
                        // Om det finns fler än ett av valören, använd pluralformen av valören
                        if (numDenomination > 1)
                        {
                            restResultat.Text += numDenomination + " " + plural + "\n";
                        }
                        // Om det bara finns ett av valören, använd singularformen av valören
                        if (numDenomination == 1)
                        {
                            restResultat.Text += numDenomination + " " + singular + "\n";
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tal1_Click(object sender, EventArgs e)
        {

        }

        private void tal2_Click(object sender, EventArgs e)
        {

        }

        private void tal1Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void tal2Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void restResultat_Click(object sender, EventArgs e)
        {

        }

        private void closeProgram_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
