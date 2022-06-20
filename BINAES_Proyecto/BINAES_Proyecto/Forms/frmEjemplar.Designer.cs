using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmEjemplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tlpEjemplar = new System.Windows.Forms.TableLayoutPanel();
            this.txtEjemplarID = new System.Windows.Forms.TextBox();
            this.lblNombreEjemplar = new System.Windows.Forms.Label();
            this.txtNombreEjemplar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblColeccionEjemplar = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cmbFomato = new System.Windows.Forms.ComboBox();
            this.lblidioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.cmbColeccionEjemplar = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblissn = new System.Windows.Forms.Label();
            this.txtissn = new System.Windows.Forms.TextBox();
            this.lblDoi = new System.Windows.Forms.Label();
            this.txtDoi = new System.Windows.Forms.TextBox();
            this.lblPalabrasClaves = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPortadaEejmplar = new System.Windows.Forms.Label();
            this.btnCrearEjemplar = new System.Windows.Forms.Button();
            this.txtNuevaEditorial = new System.Windows.Forms.TextBox();
            this.lblEditorialNueva = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnCrearAutor = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblInfoEjemplar = new System.Windows.Forms.Label();
            this.txtFotografia = new System.Windows.Forms.TextBox();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.txtFechaPublicacion = new System.Windows.Forms.TextBox();
            this.btnCrearEditorial = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.tlpMostrarUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMostrarUser = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tlpEjemplar.SuspendLayout();
            this.Mostrar.SuspendLayout();
            this.tlpMostrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.Mostrar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 690);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tlpEjemplar);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(859, 652);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Agergar Usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tlpEjemplar
            // 
            this.tlpEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.ColumnCount = 14;
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.Controls.Add(this.txtEjemplarID, 7, 2);
            this.tlpEjemplar.Controls.Add(this.lblNombreEjemplar, 1, 1);
            this.tlpEjemplar.Controls.Add(this.txtNombreEjemplar, 1, 2);
            this.tlpEjemplar.Controls.Add(this.label5, 1, 3);
            this.tlpEjemplar.Controls.Add(this.lblColeccionEjemplar, 1, 5);
            this.tlpEjemplar.Controls.Add(this.lblEditorial, 1, 7);
            this.tlpEjemplar.Controls.Add(this.cmbEditorial, 1, 8);
            this.tlpEjemplar.Controls.Add(this.lblFormato, 1, 9);
            this.tlpEjemplar.Controls.Add(this.cmbFomato, 1, 10);
            this.tlpEjemplar.Controls.Add(this.lblidioma, 1, 11);
            this.tlpEjemplar.Controls.Add(this.cmbIdioma, 1, 12);
            this.tlpEjemplar.Controls.Add(this.cmbColeccionEjemplar, 1, 6);
            this.tlpEjemplar.Controls.Add(this.lblISBN, 6, 3);
            this.tlpEjemplar.Controls.Add(this.txtIsbn, 6, 4);
            this.tlpEjemplar.Controls.Add(this.lblissn, 6, 5);
            this.tlpEjemplar.Controls.Add(this.txtissn, 6, 6);
            this.tlpEjemplar.Controls.Add(this.lblDoi, 6, 7);
            this.tlpEjemplar.Controls.Add(this.txtDoi, 6, 8);
            this.tlpEjemplar.Controls.Add(this.lblPalabrasClaves, 6, 9);
            this.tlpEjemplar.Controls.Add(this.textBox4, 6, 10);
            this.tlpEjemplar.Controls.Add(this.textBox1, 6, 11);
            this.tlpEjemplar.Controls.Add(this.textBox2, 6, 12);
            this.tlpEjemplar.Controls.Add(this.lblPortadaEejmplar, 1, 13);
            this.tlpEjemplar.Controls.Add(this.btnCrearEjemplar, 6, 13);
            this.tlpEjemplar.Controls.Add(this.txtNuevaEditorial, 10, 11);
            this.tlpEjemplar.Controls.Add(this.lblEditorialNueva, 10, 10);
            this.tlpEjemplar.Controls.Add(this.txtAutor, 10, 5);
            this.tlpEjemplar.Controls.Add(this.lblAutor, 10, 4);
            this.tlpEjemplar.Controls.Add(this.btnCrearAutor, 10, 7);
            this.tlpEjemplar.Controls.Add(this.textBox5, 10, 6);
            this.tlpEjemplar.Controls.Add(this.textBox6, 12, 5);
            this.tlpEjemplar.Controls.Add(this.lblInfoEjemplar, 1, 0);
            this.tlpEjemplar.Controls.Add(this.txtFotografia, 1, 14);
            this.tlpEjemplar.Controls.Add(this.dtpFechaPublicacion, 8, 1);
            this.tlpEjemplar.Controls.Add(this.txtFechaPublicacion, 1, 4);
            this.tlpEjemplar.Controls.Add(this.btnCrearEditorial, 10, 13);
            this.tlpEjemplar.Location = new System.Drawing.Point(0, 3);
            this.tlpEjemplar.Name = "tlpEjemplar";
            this.tlpEjemplar.RowCount = 16;
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.372549F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.Size = new System.Drawing.Size(858, 648);
            this.tlpEjemplar.TabIndex = 0;
            // 
            // txtEjemplarID
            // 
            this.txtEjemplarID.Location = new System.Drawing.Point(430, 83);
            this.txtEjemplarID.Name = "txtEjemplarID";
            this.txtEjemplarID.Size = new System.Drawing.Size(48, 26);
            this.txtEjemplarID.TabIndex = 13;
            // 
            // lblNombreEjemplar
            // 
            this.lblNombreEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblNombreEjemplar, 4);
            this.lblNombreEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNombreEjemplar.Location = new System.Drawing.Point(64, 40);
            this.lblNombreEjemplar.Name = "lblNombreEjemplar";
            this.lblNombreEjemplar.Size = new System.Drawing.Size(238, 40);
            this.lblNombreEjemplar.TabIndex = 1;
            this.lblNombreEjemplar.Text = "Nombre del ejemplar";
            this.lblNombreEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNombreEjemplar
            // 
            this.txtNombreEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtNombreEjemplar, 5);
            this.txtNombreEjemplar.Location = new System.Drawing.Point(64, 83);
            this.txtNombreEjemplar.Name = "txtNombreEjemplar";
            this.txtNombreEjemplar.Size = new System.Drawing.Size(299, 26);
            this.txtNombreEjemplar.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.label5, 4);
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(64, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 40);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha de publicación";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblColeccionEjemplar
            // 
            this.lblColeccionEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblColeccionEjemplar, 4);
            this.lblColeccionEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblColeccionEjemplar.Location = new System.Drawing.Point(64, 200);
            this.lblColeccionEjemplar.Name = "lblColeccionEjemplar";
            this.lblColeccionEjemplar.Size = new System.Drawing.Size(238, 40);
            this.lblColeccionEjemplar.TabIndex = 3;
            this.lblColeccionEjemplar.Text = "Colección a la que pertenece";
            this.lblColeccionEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEditorial
            // 
            this.lblEditorial.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblEditorial, 4);
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEditorial.Location = new System.Drawing.Point(64, 280);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(238, 40);
            this.lblEditorial.TabIndex = 18;
            this.lblEditorial.Text = "Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbEditorial
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbEditorial, 4);
            this.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(64, 323);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(218, 28);
            this.cmbEditorial.TabIndex = 31;
            // 
            // lblFormato
            // 
            this.lblFormato.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblFormato, 4);
            this.lblFormato.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFormato.Location = new System.Drawing.Point(64, 360);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(238, 40);
            this.lblFormato.TabIndex = 21;
            this.lblFormato.Text = "Formato";
            this.lblFormato.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbFomato
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbFomato, 4);
            this.cmbFomato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFomato.FormattingEnabled = true;
            this.cmbFomato.Location = new System.Drawing.Point(64, 403);
            this.cmbFomato.Name = "cmbFomato";
            this.cmbFomato.Size = new System.Drawing.Size(218, 28);
            this.cmbFomato.TabIndex = 32;
            // 
            // lblidioma
            // 
            this.lblidioma.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblidioma, 4);
            this.lblidioma.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblidioma.Location = new System.Drawing.Point(64, 440);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(238, 41);
            this.lblidioma.TabIndex = 14;
            this.lblidioma.Text = "Idioma";
            this.lblidioma.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbIdioma
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbIdioma, 3);
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(64, 484);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(162, 28);
            this.cmbIdioma.TabIndex = 27;
            // 
            // cmbColeccionEjemplar
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbColeccionEjemplar, 4);
            this.cmbColeccionEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColeccionEjemplar.FormattingEnabled = true;
            this.cmbColeccionEjemplar.Location = new System.Drawing.Point(64, 243);
            this.cmbColeccionEjemplar.Name = "cmbColeccionEjemplar";
            this.cmbColeccionEjemplar.Size = new System.Drawing.Size(218, 28);
            this.cmbColeccionEjemplar.TabIndex = 34;
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblISBN, 2);
            this.lblISBN.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblISBN.Location = new System.Drawing.Point(369, 120);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(116, 40);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "isbn";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtIsbn, 3);
            this.txtIsbn.Location = new System.Drawing.Point(369, 163);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(177, 26);
            this.txtIsbn.TabIndex = 11;
            // 
            // lblissn
            // 
            this.lblissn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblissn, 4);
            this.lblissn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblissn.Location = new System.Drawing.Point(369, 200);
            this.lblissn.Name = "lblissn";
            this.lblissn.Size = new System.Drawing.Size(238, 40);
            this.lblissn.TabIndex = 7;
            this.lblissn.Text = "issn";
            this.lblissn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtissn
            // 
            this.txtissn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtissn, 3);
            this.txtissn.Location = new System.Drawing.Point(369, 243);
            this.txtissn.Name = "txtissn";
            this.txtissn.Size = new System.Drawing.Size(177, 26);
            this.txtissn.TabIndex = 22;
            // 
            // lblDoi
            // 
            this.lblDoi.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblDoi, 4);
            this.lblDoi.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDoi.Location = new System.Drawing.Point(369, 280);
            this.lblDoi.Name = "lblDoi";
            this.lblDoi.Size = new System.Drawing.Size(238, 40);
            this.lblDoi.TabIndex = 20;
            this.lblDoi.Text = "doi";
            this.lblDoi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDoi
            // 
            this.txtDoi.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtDoi, 3);
            this.txtDoi.Location = new System.Drawing.Point(369, 323);
            this.txtDoi.Name = "txtDoi";
            this.txtDoi.Size = new System.Drawing.Size(177, 26);
            this.txtDoi.TabIndex = 23;
            // 
            // lblPalabrasClaves
            // 
            this.lblPalabrasClaves.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblPalabrasClaves, 4);
            this.lblPalabrasClaves.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPalabrasClaves.Location = new System.Drawing.Point(369, 360);
            this.lblPalabrasClaves.Name = "lblPalabrasClaves";
            this.lblPalabrasClaves.Size = new System.Drawing.Size(238, 40);
            this.lblPalabrasClaves.TabIndex = 25;
            this.lblPalabrasClaves.Text = "Palabras Claves";
            this.lblPalabrasClaves.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.textBox4, 3);
            this.textBox4.Location = new System.Drawing.Point(369, 403);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 26);
            this.textBox4.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Location = new System.Drawing.Point(369, 443);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 26);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.textBox2, 3);
            this.textBox2.Location = new System.Drawing.Point(369, 484);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 26);
            this.textBox2.TabIndex = 29;
            // 
            // lblPortadaEejmplar
            // 
            this.lblPortadaEejmplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblPortadaEejmplar, 4);
            this.lblPortadaEejmplar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPortadaEejmplar.Location = new System.Drawing.Point(64, 519);
            this.lblPortadaEejmplar.Name = "lblPortadaEejmplar";
            this.lblPortadaEejmplar.Size = new System.Drawing.Size(238, 40);
            this.lblPortadaEejmplar.TabIndex = 9;
            this.lblPortadaEejmplar.Text = "Fotografia";
            this.lblPortadaEejmplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCrearEjemplar
            // 
            this.btnCrearEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEjemplar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearEjemplar, 3);
            this.btnCrearEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearEjemplar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearEjemplar.Location = new System.Drawing.Point(369, 522);
            this.btnCrearEjemplar.Name = "btnCrearEjemplar";
            this.btnCrearEjemplar.Size = new System.Drawing.Size(177, 34);
            this.btnCrearEjemplar.TabIndex = 12;
            this.btnCrearEjemplar.Text = "Crear Ejemplar";
            this.btnCrearEjemplar.UseVisualStyleBackColor = false;
            this.btnCrearEjemplar.Click += new System.EventHandler(this.btnCrearEjemplar_Click);
            // 
            // txtNuevaEditorial
            // 
            this.tlpEjemplar.SetColumnSpan(this.txtNuevaEditorial, 3);
            this.txtNuevaEditorial.Location = new System.Drawing.Point(613, 443);
            this.txtNuevaEditorial.Name = "txtNuevaEditorial";
            this.txtNuevaEditorial.Size = new System.Drawing.Size(157, 26);
            this.txtNuevaEditorial.TabIndex = 36;
            // 
            // lblEditorialNueva
            // 
            this.lblEditorialNueva.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblEditorialNueva, 4);
            this.lblEditorialNueva.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEditorialNueva.Location = new System.Drawing.Point(613, 400);
            this.lblEditorialNueva.Name = "lblEditorialNueva";
            this.lblEditorialNueva.Size = new System.Drawing.Size(242, 40);
            this.lblEditorialNueva.TabIndex = 35;
            this.lblEditorialNueva.Text = "Nueva Editorial";
            this.lblEditorialNueva.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtAutor, 2);
            this.txtAutor.Location = new System.Drawing.Point(613, 203);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(116, 26);
            this.txtAutor.TabIndex = 6;
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblAutor, 4);
            this.lblAutor.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAutor.Location = new System.Drawing.Point(613, 160);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(242, 40);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor (es)";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCrearAutor
            // 
            this.btnCrearAutor.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearAutor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearAutor, 3);
            this.btnCrearAutor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearAutor.Location = new System.Drawing.Point(613, 283);
            this.btnCrearAutor.Name = "btnCrearAutor";
            this.btnCrearAutor.Size = new System.Drawing.Size(177, 34);
            this.btnCrearAutor.TabIndex = 33;
            this.btnCrearAutor.Text = "Autor";
            this.btnCrearAutor.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.textBox5, 2);
            this.textBox5.Location = new System.Drawing.Point(613, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 26);
            this.textBox5.TabIndex = 37;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.textBox6, 2);
            this.textBox6.Location = new System.Drawing.Point(735, 203);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 26);
            this.textBox6.TabIndex = 38;
            // 
            // lblInfoEjemplar
            // 
            this.lblInfoEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblInfoEjemplar, 5);
            this.lblInfoEjemplar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoEjemplar.Location = new System.Drawing.Point(64, 0);
            this.lblInfoEjemplar.Name = "lblInfoEjemplar";
            this.lblInfoEjemplar.Size = new System.Drawing.Size(299, 40);
            this.lblInfoEjemplar.TabIndex = 0;
            this.lblInfoEjemplar.Text = "Información del ejemplar";
            // 
            // txtFotografia
            // 
            this.tlpEjemplar.SetColumnSpan(this.txtFotografia, 3);
            this.txtFotografia.Location = new System.Drawing.Point(64, 562);
            this.txtFotografia.Name = "txtFotografia";
            this.txtFotografia.Size = new System.Drawing.Size(162, 26);
            this.txtFotografia.TabIndex = 40;
            // 
            // dtpFechaPublicacion
            // 
            this.tlpEjemplar.SetColumnSpan(this.dtpFechaPublicacion, 4);
            this.dtpFechaPublicacion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(491, 43);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(218, 26);
            this.dtpFechaPublicacion.TabIndex = 30;
            // 
            // txtFechaPublicacion
            // 
            this.tlpEjemplar.SetColumnSpan(this.txtFechaPublicacion, 3);
            this.txtFechaPublicacion.Location = new System.Drawing.Point(64, 163);
            this.txtFechaPublicacion.Name = "txtFechaPublicacion";
            this.txtFechaPublicacion.Size = new System.Drawing.Size(162, 26);
            this.txtFechaPublicacion.TabIndex = 41;
            // 
            // btnCrearEditorial
            // 
            this.btnCrearEditorial.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEditorial.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearEditorial, 3);
            this.btnCrearEditorial.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearEditorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearEditorial.Location = new System.Drawing.Point(613, 522);
            this.btnCrearEditorial.Name = "btnCrearEditorial";
            this.btnCrearEditorial.Size = new System.Drawing.Size(177, 34);
            this.btnCrearEditorial.TabIndex = 42;
            this.btnCrearEditorial.Text = "Crear Editorial";
            this.btnCrearEditorial.UseVisualStyleBackColor = false;
            this.btnCrearEditorial.Click += new System.EventHandler(this.btnCrearEditorial_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(859, 652);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Editar Usuario";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.tlpMostrarUsuario);
            this.Mostrar.Location = new System.Drawing.Point(4, 34);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(3);
            this.Mostrar.Size = new System.Drawing.Size(859, 652);
            this.Mostrar.TabIndex = 2;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            // 
            // tlpMostrarUsuario
            // 
            this.tlpMostrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMostrarUsuario.ColumnCount = 4;
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpMostrarUsuario.Controls.Add(this.dgvMostrarUser, 1, 2);
            this.tlpMostrarUsuario.Controls.Add(this.btnMostrar, 2, 0);
            this.tlpMostrarUsuario.Location = new System.Drawing.Point(3, 3);
            this.tlpMostrarUsuario.Name = "tlpMostrarUsuario";
            this.tlpMostrarUsuario.RowCount = 4;
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMostrarUsuario.Size = new System.Drawing.Size(853, 646);
            this.tlpMostrarUsuario.TabIndex = 2;
            // 
            // dgvMostrarUser
            // 
            this.dgvMostrarUser.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMostrarUsuario.SetColumnSpan(this.dgvMostrarUser, 2);
            this.dgvMostrarUser.Location = new System.Drawing.Point(122, 99);
            this.dgvMostrarUser.Name = "dgvMostrarUser";
            this.dgvMostrarUser.RowHeadersWidth = 62;
            this.dgvMostrarUser.RowTemplate.Height = 28;
            this.dgvMostrarUser.Size = new System.Drawing.Size(605, 438);
            this.dgvMostrarUser.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (5)))), ((int) (((byte) (29)))), ((int) (((byte) (64)))));
            this.btnMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrar.Location = new System.Drawing.Point(525, 3);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(202, 54);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Usuarios";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // frmEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 690);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEjemplar";
            this.Text = "frmEjemplar";
            this.Load += new System.EventHandler(this.frmEjemplar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpEjemplar.ResumeLayout(false);
            this.tlpEjemplar.PerformLayout();
            this.Mostrar.ResumeLayout(false);
            this.tlpMostrarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCrearEditorial;

        private System.Windows.Forms.TextBox txtFechaPublicacion;

        private System.Windows.Forms.TextBox txtFotografia;

        private System.Windows.Forms.Label lblEditorialNueva;
        private System.Windows.Forms.TextBox txtNuevaEditorial;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.ComboBox cmbColeccionEjemplar;

        private System.Windows.Forms.Button btnCrearAutor;

        private System.Windows.Forms.ComboBox cmbFomato;

        private System.Windows.Forms.ComboBox cmbEditorial;

        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.ComboBox cmbIdioma;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tlpEjemplar;
        private System.Windows.Forms.Label lblInfoEjemplar;
        private System.Windows.Forms.TextBox txtNombreEjemplar;
        private System.Windows.Forms.Label lblNombreEjemplar;
        private System.Windows.Forms.Label lblColeccionEjemplar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblPortadaEejmplar;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Button btnCrearEjemplar;
        private System.Windows.Forms.Label lblissn;
        private System.Windows.Forms.TextBox txtEjemplarID;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblDoi;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TextBox txtissn;
        private System.Windows.Forms.TextBox txtDoi;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblPalabrasClaves;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage Mostrar;
        private System.Windows.Forms.TableLayoutPanel tlpMostrarUsuario;
        private System.Windows.Forms.DataGridView dgvMostrarUser;
        private System.Windows.Forms.Button btnMostrar;

        #endregion
    }
}