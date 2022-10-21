using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{ 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string conta;
        int resultadoTotal;
        int numUm;
        int numDois;
        string resultado;
        bool SinalJaFoi = false;
        string operador;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Click_Num1(object sender, RoutedEventArgs e)
        {
            Conta.Text += "1";
            conta = Conta.Text;
        }

        private void Click_Num2(object sender, RoutedEventArgs e)
        {
            Conta.Text += "2";
            conta = Conta.Text;
        }

        private void Click_Num3(object sender, RoutedEventArgs e)
        {
            Conta.Text += "3";
            conta = Conta.Text;
        }

        private void Click_Num4(object sender, RoutedEventArgs e)
        {
            Conta.Text += "4";
            conta = Conta.Text;
        }

        private void Click_Num5(object sender, RoutedEventArgs e)
        {
            Conta.Text += "5";
            conta = Conta.Text;
        }

        private void Click_Num6(object sender, RoutedEventArgs e)
        {
            Conta.Text += "6";
            conta = Conta.Text;
        }

        private void Click_Num7(object sender, RoutedEventArgs e)
        {
            Conta.Text += "7";
            conta = Conta.Text;
        }

        private void Click_Num8(object sender, RoutedEventArgs e)
        {
            Conta.Text += "8";
            conta = Conta.Text;
        }

        private void Click_Num9(object sender, RoutedEventArgs e)
        {
            Conta.Text += "9";
            conta = Conta.Text;
        }

        private void Click_Num0(object sender, RoutedEventArgs e)
        {
            Conta.Text += "0";
            conta = Conta.Text;
        }

        private void btnVírgula_Click(object sender, RoutedEventArgs e)
        {
            Conta.Text += ".";
            conta = Conta.Text;
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            if(SinalJaFoi == false)
            {
                
                if(Visor.Text != "")
                {
                    if(operador != "+")
                    {
                        resultado = $"{numUm}{operador}{numDois}";
                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                    }
                    operador = "+";
                    resultado = $"{numUm + numDois}";
                    numUm = Convert.ToInt32(resultado);
                    Visor.Text = $"{numUm}";
                    Visor.Text += "+";
                    Conta.Text = $"";
                    SinalJaFoi = true;

                }
                else
                {
                    if (operador != "+")
                    {
                        resultado = $"{numUm}{operador}{numDois}";
                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                    }
                    operador = "+";
                    numUm = Convert.ToInt32(Conta.Text);
                    conta = Conta.Text;
                    Conta.Text = "";
                    Visor.Text = conta;
                    Visor.Text += "+";
                    SinalJaFoi = true;
                }
                
                
            }
            else
            {
                if(Conta.Text == "")
                {
                    Visor.Text = Visor.Text;
                }
                else
                {
                    numDois = Convert.ToInt32(Conta.Text);
                    resultado = $"{numUm + numDois}";
                    numUm = Convert.ToInt32(resultado);
                    Visor.Text = $"{numUm}";
                    Visor.Text += "+";
                    Conta.Text = $"";
                    SinalJaFoi = false;
                }
               
            }
        }

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {
            if (SinalJaFoi == false)
            {
                if (Visor.Text != "")
                {
                    if (operador != "/")
                    {
                        resultado = $"{numUm}{operador}{numDois}";
                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "/";
                    }
                    else
                    {
                        operador = "/";
                    }
                    resultado = $"{numUm / numDois}";
                    numUm = Convert.ToInt32(resultado);
                    Visor.Text = $"{numUm}";
                    Visor.Text += "/";
                    Conta.Text = $"";
                    SinalJaFoi = true;

                }
                else
                {

                    operador = "/";
                    numUm = Convert.ToInt32(Conta.Text);
                    conta = Conta.Text;
                    Conta.Text = "";
                    Visor.Text = conta;
                    Visor.Text += "/";
                    SinalJaFoi = true;
                }


            }
            else
            {
                if (Conta.Text == "")
                {
                    Visor.Text = Visor.Text;
                }
                else
                {
                    if (operador != "/")
                    {
                        resultado = $"{numUm}{operador}{numDois}";
                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "/";
                    }
                    else
                    {
                        operador = "/";
                    }
                    numDois = Convert.ToInt32(Conta.Text);
                    resultado = $"{numUm / numDois}";
                    numUm = Convert.ToInt32(resultado);
                    Visor.Text = $"{numUm}";
                    Visor.Text += "/";
                    Conta.Text = $"";
                    SinalJaFoi = false;
                }

            }
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            
            if (SinalJaFoi == false)
            {

                if (Visor.Text != "")
                {
                    if (operador != "-")
                    {
                        resultado = $"{numUm}{operador}{numDois}";
                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "-";
                    }
                    else
                    {
                        operador = "-";
                    }
                    operador = "-";
                    resultado = $"{numUm - numDois}";
                    numUm = Convert.ToInt32(resultado);
                    Visor.Text = $"{numUm}";
                    Visor.Text += "-";
                    Conta.Text = $"";
                    SinalJaFoi = true;

                }
                else
                {

                    operador = "-";
                    numUm = Convert.ToInt32(Conta.Text);
                    conta = Conta.Text;
                    Conta.Text = "";
                    Visor.Text = conta;
                    Visor.Text += "-";
                    SinalJaFoi = true;
                }


            }
            else
            {
                if (Conta.Text == "")
                {
                    Visor.Text = Visor.Text;
                }
                else
                {
                    if (operador != "-")
                    {
                        resultado = $"{numUm}{operador}{numDois}";
                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "-";
                    }
                    else
                    {
                        operador = "-";
                    }
                    operador = "-";
                    numDois = Convert.ToInt32(Conta.Text);
                    resultado = $"{numUm - numDois}";
                    numUm = Convert.ToInt32(resultado);
                    Visor.Text = $"{numUm}";
                    Visor.Text += "-";
                    Conta.Text = $"";
                    SinalJaFoi = false;
                }

            }
        }

        private void btnVezes_Click(object sender, RoutedEventArgs e)
        {
            if (SinalJaFoi == false)
            {
                if (Visor.Text != "")
                {
                    if (operador != "*")
                    {
                        resultado = $"{numUm}{operador}{numDois}";
                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "*";
                    }
                    else
                    {
                        operador = "*";
                    }


                    resultado = $"{numUm * numDois}";
                    numUm = Convert.ToInt32(resultado);
                    Visor.Text = $"{numUm}";
                    Visor.Text += "*";
                    Conta.Text = $"";
                    SinalJaFoi = true;

                }
                else
                {
                    operador = "*";
                    numUm = Convert.ToInt32(Conta.Text);
                    conta = Conta.Text;
                    Conta.Text = "";
                    Visor.Text = conta;
                    Visor.Text += "*";
                    SinalJaFoi = true;
                }


            }
            else
            {
                if (Conta.Text == "")
                {
                    Visor.Text = Visor.Text;
                }
                else
                {
                    if (operador != "*")
                    {
                        resultado = $"{numUm}{operador}{numDois}";
                        resultadoTotal = Convert.ToInt32(resultado);
                        Visor.Text = $"{resultadoTotal}";
                        operador = "*";
                    }
                    else
                    {
                        operador = "*";
                    }
                    operador = "*";
                    numDois = Convert.ToInt32(Conta.Text);
                    resultado = $"{numUm * numDois}";
                    numUm = Convert.ToInt32(resultado);
                    Visor.Text = $"{numUm}";
                    Visor.Text += "*";
                    Conta.Text = $"";
                    SinalJaFoi = false;
                }

            }
        }

        
    }
}
