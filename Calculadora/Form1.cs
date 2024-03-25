using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string expresionActual = "";
        private bool nuevaOperacion = true;

        public Form1()
        {
            InitializeComponent();
        }

        // Métodos auxiliares para el texto
        private void AgregarCaracter(string caracter)
        {
            if (nuevaOperacion)
            {
                nuevaOperacion = false;
            }
            expresionActual += caracter;
            textBoxExpresion.Text += caracter;
        }
        private void BorrarUltimoCaracter()
        {
            if (!string.IsNullOrEmpty(expresionActual))
            {
                expresionActual = expresionActual.Remove(expresionActual.Length - 1);
                textBoxExpresion.Text = textBoxExpresion.Text.Remove(textBoxExpresion.Text.Length - 1);
            }
        }

        // Agregando funcionalidad a los botones
        private void buttonNumero_Click(object sender, EventArgs e)
        {
            string caracter = ((Button)sender).Text;
            AgregarCaracter(caracter);
        }
        private void buttonOperador_Click(object sender, EventArgs e)
        {
            string operador = ((Button)sender).Text;
            if (!string.IsNullOrEmpty(expresionActual))
            {
                if (EsOperador(expresionActual[expresionActual.Length - 1]))
                {
                    BorrarUltimoCaracter();
                }
                AgregarCaracter(operador);
            }
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = EvaluarExpresion(expresionActual);
                textBoxResultado.Text = resultado.ToString();
                nuevaOperacion = true;
            }
            catch (Exception ex)
            {
                textBoxResultado.Text = "Error: " + ex.Message;
            }
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            expresionActual = "";
            nuevaOperacion = true;
            textBoxExpresion.Text = "";
        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            BorrarUltimoCaracter();
        }

        // Procesando la operacion para el resultado
        private double EvaluarExpresion(string expresion)
        {
            Queue<string> postfijo = ConvertirAPostfijo(expresion);
            Stack<double> pila = new Stack<double>();
            while (postfijo.Count > 0)
            {
                string elemento = postfijo.Dequeue();
                if (double.TryParse(elemento, out double numero))
                {
                    pila.Push(numero);
                }
                else if (EsOperador(elemento[0]))
                {
                    if (pila.Count < 2)
                    {
                        throw new InvalidOperationException("Expresión inválida");
                    }
                    double operando2 = pila.Pop();
                    double operando1 = pila.Pop();
                    double resultado = Operar(elemento[0], operando1, operando2);
                    pila.Push(resultado);
                }
                else
                {
                    throw new InvalidOperationException("Carácter no reconocido en la expresión");
                }
            }

            if (pila.Count != 1)
            {
                throw new InvalidOperationException("Expresión inválida");
            }
            return pila.Pop();
        }
        private Queue<string> ConvertirAPostfijo(string expresion)
        {
            Queue<string> postfijo = new Queue<string>();
            Stack<char> pila = new Stack<char>();
            string numeroActual = "";
            foreach (char caracter in expresion)
            {
                if (char.IsDigit(caracter) || caracter == '.')
                {
                    // Agregar el dígito al número actual
                    numeroActual += caracter;
                }
                else if (EsOperador(caracter))
                {
                    // Si hay un número actual, agregarlo a la cola postfija
                    if (!string.IsNullOrEmpty(numeroActual))
                    {
                        postfijo.Enqueue(numeroActual);
                        numeroActual = ""; // Reiniciar el número actual
                    }

                    // Agregar el operador a la cola postfija
                    while (pila.Count > 0 && PrecedenciaOperador(caracter) <= PrecedenciaOperador(pila.Peek()))
                    {
                        postfijo.Enqueue(pila.Pop().ToString());
                    }
                    pila.Push(caracter);
                }
                else if (caracter == '(')
                {
                    pila.Push(caracter);
                }
                else if (caracter == ')')
                {
                    // Si hay un número actual, agregarlo a la cola postfija
                    if (!string.IsNullOrEmpty(numeroActual))
                    {
                        postfijo.Enqueue(numeroActual);
                        numeroActual = ""; // Reiniciar el número actual
                    }
                    // Agregar operadores de la pila a la cola postfija hasta encontrar '('
                    while (pila.Count > 0 && pila.Peek() != '(')
                    {
                        postfijo.Enqueue(pila.Pop().ToString());
                    }
                    if (pila.Count == 0)
                    {
                        throw new InvalidOperationException("Paréntesis desbalanceados");
                    }
                    pila.Pop(); // Sacar el '(' de la pila
                }
            }
            // Si hay un número actual, agregarlo a la cola postfija
            if (!string.IsNullOrEmpty(numeroActual))
            {
                postfijo.Enqueue(numeroActual);
            }
            // Agregar operadores restantes de la pila a la cola postfija
            while (pila.Count > 0)
            {
                if (pila.Peek() == '(')
                {
                    throw new InvalidOperationException("Paréntesis desbalanceados");
                }
                postfijo.Enqueue(pila.Pop().ToString());
            }
            return postfijo;
        }
        private int PrecedenciaOperador(char operador)
        {
            switch (operador)
            {
                case '*':
                case '/':
                    return 2;
                case '+':
                case '-':
                    return 1;
                default:
                    return 0;
            }
        }
        private double Operar(char operador, double operando1, double operando2)
        {
            switch (operador)
            {
                case '+':
                    return operando1 + operando2;
                case '-':
                    return operando1 - operando2;
                case '*':
                    return operando1 * operando2;
                case '/':
                    if (operando2 == 0)
                    {
                        throw new DivideByZeroException("División por cero");
                    }
                    return operando1 / operando2;
                default:
                    throw new ArgumentException("Operador no válido");
            }
        }
        private bool EsOperador(char caracter)
        {
            return caracter == '+' || caracter == '-' || caracter == '*' || caracter == '/';
        }

    }
}
