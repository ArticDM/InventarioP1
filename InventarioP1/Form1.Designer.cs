namespace InventarioP1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelInv = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            bindingSource1 = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            tbDescrip = new TextBox();
            btRegistrar = new Button();
            label5 = new Label();
            tbNotas = new TextBox();
            label6 = new Label();
            cbEstatus = new ComboBox();
            tbMarca = new TextBox();
            tbCodigo = new TextBox();
            tbModelo = new TextBox();
            dtIngreso = new DateTimePicker();
            tbSerie = new TextBox();
            cbResponsable = new ComboBox();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            tbNombre = new TextBox();
            tbRRegistrar = new Button();
            cbREstatus = new ComboBox();
            tbArea = new TextBox();
            panelResp = new Panel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panelInv
            // 
            panelInv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInv.Location = new Point(3, 125);
            panelInv.Name = "panelInv";
            panelInv.Size = new Size(891, 371);
            panelInv.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(932, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(908, 530);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(panelInv);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(900, 502);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inventario";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tbDescrip);
            groupBox1.Controls.Add(btRegistrar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbNotas);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbEstatus);
            groupBox1.Controls.Add(tbMarca);
            groupBox1.Controls.Add(tbCodigo);
            groupBox1.Controls.Add(tbModelo);
            groupBox1.Controls.Add(dtIngreso);
            groupBox1.Controls.Add(tbSerie);
            groupBox1.Controls.Add(cbResponsable);
            groupBox1.Location = new Point(3, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(891, 104);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Registro";
            // 
            // tbDescrip
            // 
            tbDescrip.Location = new Point(6, 16);
            tbDescrip.Name = "tbDescrip";
            tbDescrip.PlaceholderText = "Descripción";
            tbDescrip.Size = new Size(100, 23);
            tbDescrip.TabIndex = 10;
            tbDescrip.Leave += datos_TextChanged;
            // 
            // btRegistrar
            // 
            btRegistrar.BackColor = Color.SteelBlue;
            btRegistrar.ForeColor = SystemColors.ControlLight;
            btRegistrar.Location = new Point(807, 22);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(75, 70);
            btRegistrar.TabIndex = 19;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 77);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 5;
            label5.Text = "Responsable:";
            // 
            // tbNotas
            // 
            tbNotas.Location = new Point(582, 16);
            tbNotas.Multiline = true;
            tbNotas.Name = "tbNotas";
            tbNotas.PlaceholderText = "Notas";
            tbNotas.Size = new Size(219, 81);
            tbNotas.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 51);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 6;
            label6.Text = "Ingreso:";
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbEstatus.Location = new Point(455, 74);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(121, 23);
            cbEstatus.TabIndex = 17;
            cbEstatus.Text = "ACTIVO";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(112, 16);
            tbMarca.Name = "tbMarca";
            tbMarca.PlaceholderText = "Marca";
            tbMarca.Size = new Size(100, 23);
            tbMarca.TabIndex = 11;
            tbMarca.Leave += datos_TextChanged;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(349, 74);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.PlaceholderText = "Código";
            tbCodigo.Size = new Size(100, 23);
            tbCodigo.TabIndex = 16;
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(218, 16);
            tbModelo.Name = "tbModelo";
            tbModelo.PlaceholderText = "Modelo";
            tbModelo.Size = new Size(185, 23);
            tbModelo.TabIndex = 12;
            tbModelo.Leave += datos_TextChanged;
            // 
            // dtIngreso
            // 
            dtIngreso.Format = DateTimePickerFormat.Short;
            dtIngreso.Location = new Point(112, 45);
            dtIngreso.Name = "dtIngreso";
            dtIngreso.Size = new Size(100, 23);
            dtIngreso.TabIndex = 14;
            // 
            // tbSerie
            // 
            tbSerie.Location = new Point(409, 16);
            tbSerie.Name = "tbSerie";
            tbSerie.PlaceholderText = "Serie";
            tbSerie.Size = new Size(167, 23);
            tbSerie.TabIndex = 13;
            tbSerie.Leave += datos_TextChanged;
            // 
            // cbResponsable
            // 
            cbResponsable.FormattingEnabled = true;
            cbResponsable.Location = new Point(112, 74);
            cbResponsable.Name = "cbResponsable";
            cbResponsable.Size = new Size(169, 23);
            cbResponsable.TabIndex = 15;
            cbResponsable.Text = "STOCK";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(panelResp);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(900, 502);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Responsable";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tbNombre);
            groupBox2.Controls.Add(tbRRegistrar);
            groupBox2.Controls.Add(cbREstatus);
            groupBox2.Controls.Add(tbArea);
            groupBox2.Location = new Point(3, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(888, 104);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nuevo Registro";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(6, 16);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombre";
            tbNombre.Size = new Size(294, 23);
            tbNombre.TabIndex = 10;
            // 
            // tbRRegistrar
            // 
            tbRRegistrar.BackColor = Color.SteelBlue;
            tbRRegistrar.ForeColor = SystemColors.ControlLight;
            tbRRegistrar.Location = new Point(807, 20);
            tbRRegistrar.Name = "tbRRegistrar";
            tbRRegistrar.Size = new Size(75, 70);
            tbRRegistrar.TabIndex = 13;
            tbRRegistrar.Text = "Registrar";
            tbRRegistrar.UseVisualStyleBackColor = false;
            tbRRegistrar.Click += tbRRegistrar_Click;
            // 
            // cbREstatus
            // 
            cbREstatus.FormattingEnabled = true;
            cbREstatus.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbREstatus.Location = new Point(6, 74);
            cbREstatus.Name = "cbREstatus";
            cbREstatus.Size = new Size(121, 23);
            cbREstatus.TabIndex = 12;
            cbREstatus.Text = "ACTIVO";
            // 
            // tbArea
            // 
            tbArea.Location = new Point(6, 45);
            tbArea.Name = "tbArea";
            tbArea.PlaceholderText = "Area";
            tbArea.Size = new Size(167, 23);
            tbArea.TabIndex = 11;
            // 
            // panelResp
            // 
            panelResp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelResp.Location = new Point(3, 125);
            panelResp.Name = "panelResp";
            panelResp.Size = new Size(891, 412);
            panelResp.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 570);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Inventario";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelInv;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private BindingSource bindingSource1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panelResp;
        private TextBox tbSerie;
        private TextBox tbModelo;
        private TextBox tbMarca;
        private TextBox tbDescrip;
        private Label label6;
        private Label label5;
        private ComboBox cbEstatus;
        private TextBox tbCodigo;
        private DateTimePicker dtIngreso;
        private ComboBox cbResponsable;
        private TextBox tbNotas;
        private Button btRegistrar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbNombre;
        private Button tbRRegistrar;
        private ComboBox cbREstatus;
        private TextBox tbArea;
    }
}
