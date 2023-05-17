using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double valor = double.Parse(valorTextBox.Text);
                if (temperaturaComboBox.SelectedItem != null)
                {
                    temperaturaComboBox.SelectedItem.ToString();
                    if (temperaturaComboBox.SelectedItem.ToString() == "Celsius")
                    {
                        resultadoLabel.Text = CelsiusToFahrenheit(valor);
                        resultadoLabel2.Text = CelsiusToKelvin(valor);
                    }
                    else if (temperaturaComboBox.SelectedItem.ToString() == "Fahrenheit")
                    {
                        resultadoLabel.Text = FahrenheitToCelsius(valor);
                        resultadoLabel2.Text = FahrenheitToKelvin(valor);
                    }
                    else if (temperaturaComboBox.SelectedItem.ToString() == "Kelvin")
                    {
                        resultadoLabel.Text = KelvinToCelsius(valor);
                        resultadoLabel2.Text = KelvinToFahrenheit(valor);
                    }
                }
                else
                {
                    MessageBox.Show("Ingresar Valores correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Ingresar Valores correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private string CelsiusToFahrenheit(double celsius)
        {
            return "El valor en Fahrenheit: " + ((celsius * 9 / 5) + 32).ToString();
        }

        private string FahrenheitToCelsius(double fahrenheit)
        {
            return "El valor en Celsius: " + (((fahrenheit - 32) * 5) / 9).ToString();
        }

        private string KelvinToCelsius(double kelvin)
        {
            return "El valor en Celsius: " + (kelvin - 273.15).ToString();
        }

        private string CelsiusToKelvin(double celsius)
        {
            return "El valor en Kelvin: " + (celsius + 273.15).ToString();
        }

        private string FahrenheitToKelvin(double fahrenheit)
        {
            return "El valor en Kelvin: " + ((fahrenheit + 459.67) * 5 / 9).ToString();
        }

        private string KelvinToFahrenheit(double kelvin)
        {
            return "El valor en Fahrenheit: " + ((kelvin * 9 / 5) - 459.67).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = double.Parse(textBox3.Text);

                if (monedaComboBox.SelectedItem != null)
                {
                    string monedaSeleccionada = monedaComboBox.SelectedItem.ToString();

                    if (monedaSeleccionada == "Quetzales")
                    {
                        textBox1.Text = QuetzalesToDolar(valor);
                        textBox2.Text = QuetzalesToEuro(valor);
                    }
                    else if (monedaSeleccionada == "Dólar")
                    {
                        textBox1.Text = DolarToQuetzales(valor);
                        textBox2.Text = DolarToEuro(valor);
                    }
                    else if (monedaSeleccionada == "Euro")
                    {
                        textBox1.Text = EuroToQuetzales(valor);
                        textBox2.Text = EuroToDolar(valor);
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una opción de moneda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresar valores correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string QuetzalesToDolar(double quetzales)
        {
            double dolar = quetzales / 7.8; 
            return "El valor en Dólar: " + dolar.ToString();
        }

        private string QuetzalesToEuro(double quetzales)
        {
            double euro = quetzales / 9.3; 
            return "El valor en Euro: " + euro.ToString();
        }

        private string DolarToQuetzales(double dolares)
        {
            double quetzales = dolares * 7.8;
            return "El valor en Quetzales: " + quetzales.ToString();
        }

        private string DolarToEuro(double dolares)
        {
            double euro = dolares * 0.85;
            return "El valor en Euro: " + euro.ToString();
        }

        private string EuroToQuetzales(double euros)
        {
            double quetzales = euros * 9.3; 
            return "El valor en Quetzales: " + quetzales.ToString();
        }

        private string EuroToDolar(double euros)
        {
            double dolares = euros / 0.85; 
            return "El valor en Dólar: " + dolares.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = double.Parse(textBox6.Text);

                if (distanciaComboBox.SelectedItem != null)
                {
                    string distanciaSeleccionada = distanciaComboBox.SelectedItem.ToString();

                    if (distanciaSeleccionada == "Centímetro")
                    {
                        textBox5.Text = CentimetroToMetro(valor);
                        textBox4.Text = CentimetroToKilometro(valor);
                    }
                    else if (distanciaSeleccionada == "Metro")
                    {
                        textBox5.Text = MetroToCentimetro(valor);
                        textBox4.Text = MetroToKilometro(valor);
                    }
                    else if (distanciaSeleccionada == "Kilómetro")
                    {
                        textBox5.Text = KilometroToCentimetro(valor);
                        textBox4.Text = KilometroToMetro(valor);
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una opción de distancia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresar valores correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CentimetroToMetro(double centimetros)
        {
            double metros = centimetros / 100; 
            return "El valor en Metro: " + metros.ToString();
        }

        private string CentimetroToKilometro(double centimetros)
        {
            double kilometros = centimetros / 100000;
            return "El valor en Kilómetro: " + kilometros.ToString();
        }

        private string MetroToCentimetro(double metros)
        {
            double centimetros = metros * 100;
            return "El valor en Centímetro: " + centimetros.ToString();
        }

        private string MetroToKilometro(double metros)
        {
            double kilometros = metros / 1000;
            return "El valor en Kilómetro: " + kilometros.ToString();
        }

        private string KilometroToCentimetro(double kilometros)
        {
            double centimetros = kilometros * 100000;
            return "El valor en Centímetro: " + centimetros.ToString();
        }

        private string KilometroToMetro(double kilometros)
        {
            double metros = kilometros * 1000; 
            return "El valor en Metro: " + metros.ToString();
        }



        private bool ValidarCorreoElectronico(string correo)
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.(edu|com|org)$";

            return Regex.IsMatch(correo, patron);
        }

        private bool ValidarPaginaWeb(string url)
        {
            string patron = @"^(www\.)?[a-zA-Z0-9-]+\.(com|edu|org)$";

            return Regex.IsMatch(url, patron);
        }

        private bool ValidarNumeroCelular(string numero)
        {
            // Expresiones regulares para validar el formato del número de celular en diferentes países
            string patronGuatemala = @"^(\+502)?[24678][0-9]{7}$";
            string patronEspaña = @"^(\+34)?[6789][0-9]{8}$";
            string patronMexico = @"^(\+52)?[1-9][0-9]{9}$";

            // Validar el número de celular utilizando las expresiones regulares
            return Regex.IsMatch(numero, patronGuatemala) ||
                   Regex.IsMatch(numero, patronEspaña) ||
                   Regex.IsMatch(numero, patronMexico);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texto = textBox9.Text;
            string opcionSeleccionada = tipoValidacionComboBox.SelectedItem.ToString();

            if (opcionSeleccionada == "Correo Electrónico")
            {
                bool esValido = ValidarCorreoElectronico(texto);

                if (esValido)
                {
                    MessageBox.Show("El correo electrónico es válido.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El correo electrónico no es válido.", "Validación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (opcionSeleccionada == "Página Web")
            {
                bool esValido = ValidarPaginaWeb(texto);

                if (esValido)
                {
                    MessageBox.Show("La página web es válida.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La página web no es válida.", "Validación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (opcionSeleccionada == "Número de Celular")
            {
               
                bool esValido = ValidarNumeroCelular(texto);

                if (esValido)
                {
                    MessageBox.Show("El número de celular es válido.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El número de celular no es válido.", "Validación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una opción de validación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
