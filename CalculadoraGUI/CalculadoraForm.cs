using System.Net;

namespace CalculadoraGUI
{
    public partial class CalculadoraForm : Form
    {
        Dictionary<string, Func<decimal, decimal, string>> operaciones;
        Dictionary<string, string> descOperaciones;
        public CalculadoraForm()
        {
            InitializeComponent();
            InitOperations();
            InitOperacionesComboBox();
        }

        private void InitOperations()
        {
            // Se produce una excepci�n cuando el resultado de la operacio�n superan los valores de Decimal.MinValue y Decimal.MaxValue
            operaciones = new Dictionary<string, Func<decimal, decimal, string>>
            {
                { "+", (decimal v1, decimal v2) =>
                    {
                        try
                        {
                            return (v1 + v2).ToString();
                        }
                        catch (Exception)
                        {
                            return "Valor fuera de los l�mites";
                        }
                    }
                },
                { "-", (decimal v1, decimal v2) =>
                    {
                        try
                        {
                            return (v1 - v2).ToString();
                        }
                        catch (Exception)
                        {
                            return "Valor fuera de los l�mites";
                        }
                    }
                },
                { "*", (decimal v1, decimal v2) =>
                    {
                        try
                        {
                            return (v1 * v2).ToString();
                        }
                        catch (Exception)
                        {
                            return "Valor fuera de los l�mites";
                        }
                    }
                },
                {
                    "/",
                    (decimal v1, decimal v2) =>
                    {
                        if (v2 == 0)
                        {
                            return "Divisi�n Inv�lida!";
                        }
                        try
                        {
                            return (v1 / v2).ToString();
                        }
                        catch (Exception)
                        {
                            return "Valor fuera de los l�mites";
                        }
                    }
                }
            };

            descOperaciones = new Dictionary<string, string>
            {
                { "+", "Suma" },
                { "-", "Resta" },
                { "*", "Multiplicaci�n" },
                { "/", "Divisi�n" }
            };
        }

        private void InitOperacionesComboBox()
        {
            OperacionComboBox.DataSource = new BindingSource(operaciones, null);
            OperacionComboBox.DisplayMember = "Key";
            OperacionComboBox.ValueMember = "Key";
        }

        private void Log(string text)
        {
            LogTextBox.AppendText(
                string.Format(
                    "{0}> {1}{2}",
                    DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                    text,
                    Environment.NewLine
                )
            );
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            string operacionSeleccionada = (string)OperacionComboBox.SelectedValue;
            string descripcionOperacion = descOperaciones[operacionSeleccionada];
            var operacion = operaciones[operacionSeleccionada];

            string resultado = operacion(Valor1NUD.Value, Valor2NUD.Value);
            // Opci�n de salida 1
            Log(string.Format("El resultado de la {0} es {1}", descripcionOperacion, resultado));
            // Opci�n de salida 2
            Log(string.Format("{0} {1} {2} = {3}", Valor1NUD.Value, operacionSeleccionada, Valor2NUD.Value, resultado));
        }
    }
}