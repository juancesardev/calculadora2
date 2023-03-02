namespace CalculadoraGUI
{
    partial class CalculadoraForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.V1Label = new System.Windows.Forms.Label();
            this.OpLabel = new System.Windows.Forms.Label();
            this.V2Label = new System.Windows.Forms.Label();
            this.Valor1NUD = new System.Windows.Forms.NumericUpDown();
            this.Valor2NUD = new System.Windows.Forms.NumericUpDown();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.OperationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OperacionComboBox = new System.Windows.Forms.ComboBox();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Valor1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Valor2NUD)).BeginInit();
            this.OperationLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 5;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MainTableLayoutPanel.Controls.Add(this.V1Label, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.OpLabel, 2, 1);
            this.MainTableLayoutPanel.Controls.Add(this.V2Label, 3, 1);
            this.MainTableLayoutPanel.Controls.Add(this.Valor1NUD, 1, 2);
            this.MainTableLayoutPanel.Controls.Add(this.Valor2NUD, 3, 2);
            this.MainTableLayoutPanel.Controls.Add(this.CalcularButton, 3, 3);
            this.MainTableLayoutPanel.Controls.Add(this.LogTextBox, 1, 4);
            this.MainTableLayoutPanel.Controls.Add(this.OperationLayoutPanel, 2, 2);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 5;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(534, 261);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // V1Label
            // 
            this.V1Label.AutoSize = true;
            this.V1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.V1Label.Location = new System.Drawing.Point(13, 10);
            this.V1Label.Name = "V1Label";
            this.V1Label.Size = new System.Drawing.Size(201, 30);
            this.V1Label.TabIndex = 0;
            this.V1Label.Text = "Valor 1";
            this.V1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpLabel
            // 
            this.OpLabel.AutoSize = true;
            this.OpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpLabel.Location = new System.Drawing.Point(220, 10);
            this.OpLabel.Name = "OpLabel";
            this.OpLabel.Size = new System.Drawing.Size(94, 30);
            this.OpLabel.TabIndex = 1;
            this.OpLabel.Text = "Operador";
            this.OpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // V2Label
            // 
            this.V2Label.AutoSize = true;
            this.V2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.V2Label.Location = new System.Drawing.Point(320, 10);
            this.V2Label.Name = "V2Label";
            this.V2Label.Size = new System.Drawing.Size(201, 30);
            this.V2Label.TabIndex = 2;
            this.V2Label.Text = "Valor 2";
            this.V2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Valor1NUD
            // 
            this.Valor1NUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valor1NUD.Location = new System.Drawing.Point(13, 43);
            this.Valor1NUD.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.Valor1NUD.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.Valor1NUD.Name = "Valor1NUD";
            this.Valor1NUD.Size = new System.Drawing.Size(201, 26);
            this.Valor1NUD.TabIndex = 3;
            this.Valor1NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Valor2NUD
            // 
            this.Valor2NUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valor2NUD.Location = new System.Drawing.Point(320, 43);
            this.Valor2NUD.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.Valor2NUD.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.Valor2NUD.Name = "Valor2NUD";
            this.Valor2NUD.Size = new System.Drawing.Size(201, 26);
            this.Valor2NUD.TabIndex = 5;
            this.Valor2NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalcularButton.Location = new System.Drawing.Point(320, 73);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(201, 29);
            this.CalcularButton.TabIndex = 6;
            this.CalcularButton.Text = "&Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // LogTextBox
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.LogTextBox, 3);
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(13, 108);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(508, 150);
            this.LogTextBox.TabIndex = 7;
            this.LogTextBox.WordWrap = false;
            // 
            // OperationLayoutPanel
            // 
            this.OperationLayoutPanel.ColumnCount = 3;
            this.OperationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OperationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.OperationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OperationLayoutPanel.Controls.Add(this.OperacionComboBox, 1, 0);
            this.OperationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationLayoutPanel.Location = new System.Drawing.Point(220, 43);
            this.OperationLayoutPanel.Name = "OperationLayoutPanel";
            this.OperationLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.SetRowSpan(this.OperationLayoutPanel, 2);
            this.OperationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OperationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OperationLayoutPanel.Size = new System.Drawing.Size(94, 59);
            this.OperationLayoutPanel.TabIndex = 4;
            // 
            // OperacionComboBox
            // 
            this.OperacionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperacionComboBox.FormattingEnabled = true;
            this.OperacionComboBox.Location = new System.Drawing.Point(30, 3);
            this.OperacionComboBox.Name = "OperacionComboBox";
            this.OperacionComboBox.Size = new System.Drawing.Size(34, 29);
            this.OperacionComboBox.TabIndex = 0;
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "CalculadoraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Valor1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Valor2NUD)).EndInit();
            this.OperationLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Label V1Label;
        private Label OpLabel;
        private Label V2Label;
        private NumericUpDown Valor1NUD;
        private NumericUpDown Valor2NUD;
        private Button CalcularButton;
        private TextBox LogTextBox;
        private TableLayoutPanel OperationLayoutPanel;
        private ComboBox OperacionComboBox;
    }
}