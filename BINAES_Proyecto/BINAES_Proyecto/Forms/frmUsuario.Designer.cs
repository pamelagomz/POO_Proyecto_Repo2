using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreUsuarios = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.btnGuardarQR = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnGenerarQR = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIDatualizar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtActualizarOcupacion = new System.Windows.Forms.TextBox();
            this.txtActualizarCorreo = new System.Windows.Forms.TextBox();
            this.txtActualizarInstitucion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtActualizarNombre = new System.Windows.Forms.TextBox();
            this.txtActualizarTelefono = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtActualizarDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.tlpMostrarUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMostrarUser = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Mostrar.SuspendLayout();
            this.tlpMostrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 46);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtCorreoUsuario, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblCorreoUsuario, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtCorreoUsuario
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtCorreoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.txtCorreoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.txtCorreoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtCorreoUsuario.Location = new System.Drawing.Point(103, 3);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(94, 26);
            this.txtCorreoUsuario.TabIndex = 15;
            // 
            // lblCorreoUsuario
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblCorreoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.lblCorreoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.lblCorreoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.lblCorreoUsuario.Location = new System.Drawing.Point(3, 0);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(94, 100);
            this.lblCorreoUsuario.TabIndex = 14;
            this.lblCorreoUsuario.Text = "Correo: ";
            this.lblCorreoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 114);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 46);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.textBox1.Location = new System.Drawing.Point(103, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 26);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 100);
            this.label2.TabIndex = 14;
            this.label2.Text = "Correo: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 114);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.Mostrar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
<<<<<<< HEAD
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
=======
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 690);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
<<<<<<< HEAD
<<<<<<< HEAD
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
=======
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
            this.tabPage3.Size = new System.Drawing.Size(525, 410);
=======
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 652);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Agergar Usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.ColumnCount = 14;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtNombreUsuarios, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtOcupacion, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtDireccionUsuario, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label8, 8, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtTelefono, 8, 7);
            this.tableLayoutPanel3.Controls.Add(this.label9, 10, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.txtInstitucion, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label11, 8, 8);
            this.tableLayoutPanel3.Controls.Add(this.txt, 8, 9);
            this.tableLayoutPanel3.Controls.Add(this.txtUsuarioID, 7, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnGuardarQR, 6, 11);
            this.tableLayoutPanel3.Controls.Add(this.btnCrearUsuario, 10, 11);
            this.tableLayoutPanel3.Controls.Add(this.btnGenerarQR, 2, 11);
<<<<<<< HEAD
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 2);
<<<<<<< HEAD
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
=======
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 3);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 16;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.641975F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(791, 648);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.label4, 5);
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(59, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Informacion del usuario";
            // 
            // txtNombreUsuarios
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtNombreUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtNombreUsuarios, 5);
            this.txtNombreUsuarios.Location = new System.Drawing.Point(39, 80);
            this.txtNombreUsuarios.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtNombreUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtNombreUsuarios, 5);
            this.txtNombreUsuarios.Location = new System.Drawing.Point(39, 80);
            this.txtNombreUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txtNombreUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtNombreUsuarios, 5);
            this.txtNombreUsuarios.Location = new System.Drawing.Point(59, 123);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtNombreUsuarios.Name = "txtNombreUsuarios";
            this.txtNombreUsuarios.Size = new System.Drawing.Size(274, 26);
            this.txtNombreUsuarios.TabIndex = 2;
            // 
            // label5
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.label5, 4);
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(59, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre y apellido";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.label6, 4);
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(59, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ocupacion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtOcupacion
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtOcupacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtOcupacion, 5);
            this.txtOcupacion.Location = new System.Drawing.Point(39, 132);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtOcupacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtOcupacion, 5);
            this.txtOcupacion.Location = new System.Drawing.Point(39, 132);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txtOcupacion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtOcupacion, 5);
            this.txtOcupacion.Location = new System.Drawing.Point(59, 203);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(274, 26);
            this.txtOcupacion.TabIndex = 4;
            // 
            // label7
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.label7, 4);
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(59, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 40);
            this.label7.TabIndex = 5;
            this.label7.Text = "Direccion";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDireccionUsuario
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtDireccionUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtDireccionUsuario, 5);
            this.txtDireccionUsuario.Location = new System.Drawing.Point(39, 184);
            this.txtDireccionUsuario.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtDireccionUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtDireccionUsuario, 5);
            this.txtDireccionUsuario.Location = new System.Drawing.Point(39, 184);
            this.txtDireccionUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txtDireccionUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtDireccionUsuario, 5);
            this.txtDireccionUsuario.Location = new System.Drawing.Point(59, 283);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(274, 26);
            this.txtDireccionUsuario.TabIndex = 6;
            // 
            // label8
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.label8, 4);
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(451, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefono";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTelefono
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtTelefono, 4);
            this.txtTelefono.Location = new System.Drawing.Point(298, 184);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtTelefono, 4);
            this.txtTelefono.Location = new System.Drawing.Point(298, 184);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtTelefono, 4);
            this.txtTelefono.Location = new System.Drawing.Point(451, 283);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(218, 26);
            this.txtTelefono.TabIndex = 8;
            // 
            // label9
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.label9, 4);
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(563, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 40);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fotografia";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label10
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.label10, 4);
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(59, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 40);
            this.label10.TabIndex = 10;
            this.label10.Text = "Institucion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtInstitucion
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtInstitucion, 5);
            this.txtInstitucion.Location = new System.Drawing.Point(39, 236);
            this.txtInstitucion.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtInstitucion, 5);
            this.txtInstitucion.Location = new System.Drawing.Point(39, 236);
            this.txtInstitucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txtInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtInstitucion, 5);
            this.txtInstitucion.Location = new System.Drawing.Point(59, 363);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(274, 26);
            this.txtInstitucion.TabIndex = 11;
            // 
            // label11
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.label11, 4);
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(451, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 40);
            this.label11.TabIndex = 14;
            this.label11.Text = "Correo Electronico";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txt, 4);
            this.txt.Location = new System.Drawing.Point(298, 236);
            this.txt.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txt, 4);
            this.txt.Location = new System.Drawing.Point(298, 236);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txt, 4);
            this.txt.Location = new System.Drawing.Point(451, 363);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(218, 26);
            this.txt.TabIndex = 15;
            // 
            // txtUsuarioID
            // 
<<<<<<< HEAD
            this.txtUsuarioID.Location = new System.Drawing.Point(261, 80);
<<<<<<< HEAD
            this.txtUsuarioID.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtUsuarioID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txtUsuarioID.Location = new System.Drawing.Point(395, 123);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(48, 26);
            this.txtUsuarioID.TabIndex = 13;
            // 
            // btnGuardarQR
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnGuardarQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.btnGuardarQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.btnGuardarQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
=======
            this.btnGuardarQR.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarQR.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.btnGuardarQR, 3);
            this.btnGuardarQR.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnGuardarQR.ForeColor = System.Drawing.SystemColors.ButtonFace;
<<<<<<< HEAD
            this.btnGuardarQR.Location = new System.Drawing.Point(224, 288);
<<<<<<< HEAD
            this.btnGuardarQR.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnGuardarQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.btnGuardarQR.Location = new System.Drawing.Point(339, 443);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.btnGuardarQR.Name = "btnGuardarQR";
            this.btnGuardarQR.Size = new System.Drawing.Size(162, 50);
            this.btnGuardarQR.TabIndex = 16;
            this.btnGuardarQR.Text = "Guardar QR";
            this.btnGuardarQR.UseVisualStyleBackColor = false;
            // 
            // btnCrearUsuario
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnCrearUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.btnCrearUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
=======
            this.btnCrearUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.btnCrearUsuario, 3);
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
<<<<<<< HEAD
            this.btnCrearUsuario.Location = new System.Drawing.Point(372, 288);
<<<<<<< HEAD
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.btnCrearUsuario.Location = new System.Drawing.Point(563, 443);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(162, 50);
            this.btnCrearUsuario.TabIndex = 12;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnGenerarQR
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnGenerarQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.btnGenerarQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.btnGenerarQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
=======
            this.btnGenerarQR.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarQR.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel3.SetColumnSpan(this.btnGenerarQR, 3);
            this.btnGenerarQR.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnGenerarQR.ForeColor = System.Drawing.SystemColors.ButtonFace;
<<<<<<< HEAD
            this.btnGenerarQR.Location = new System.Drawing.Point(76, 288);
<<<<<<< HEAD
            this.btnGenerarQR.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnGenerarQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.btnGenerarQR.Location = new System.Drawing.Point(115, 443);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.btnGenerarQR.Name = "btnGenerarQR";
            this.btnGenerarQR.Size = new System.Drawing.Size(162, 50);
            this.btnGenerarQR.TabIndex = 17;
            this.btnGenerarQR.Text = "Generar QR";
            this.btnGenerarQR.UseVisualStyleBackColor = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
<<<<<<< HEAD
<<<<<<< HEAD
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
=======
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
            this.tabPage4.Size = new System.Drawing.Size(525, 410);
=======
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 652);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Editar Usuario";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
=======
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel4.ColumnCount = 14;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 12);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 1);
<<<<<<< HEAD
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 1);
<<<<<<< HEAD
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
=======
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 2);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 16;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.018518F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777778F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.864198F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03086F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(791, 648);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel3, 13);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.btnEliminarUsuario);
            this.panel3.Controls.Add(this.txtIdEliminar);
<<<<<<< HEAD
            this.panel3.Location = new System.Drawing.Point(39, 313);
<<<<<<< HEAD
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel4.SetRowSpan(this.panel3, 4);
            this.panel3.Size = new System.Drawing.Size(486, 106);
=======
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel4.SetRowSpan(this.panel3, 4);
            this.panel3.Size = new System.Drawing.Size(477, 96);
>>>>>>> FERNANDO
=======
            this.panel3.Location = new System.Drawing.Point(59, 482);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel4.SetRowSpan(this.panel3, 4);
            this.panel3.Size = new System.Drawing.Size(715, 147);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.panel3.TabIndex = 22;
            // 
            // label21
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(25, 26);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
<<<<<<< HEAD
            this.label21.Size = new System.Drawing.Size(252, 37);
=======
            this.label21.Size = new System.Drawing.Size(243, 27);
>>>>>>> FERNANDO
=======
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label21.Location = new System.Drawing.Point(37, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(364, 42);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label21.TabIndex = 21;
            this.label21.Text = "Ingrese el numero de id del usuario a eliminar";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label20
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(159, 1);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
<<<<<<< HEAD
            this.label20.Size = new System.Drawing.Size(564, 35);
=======
            this.label20.Size = new System.Drawing.Size(555, 25);
>>>>>>> FERNANDO
=======
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label20.Location = new System.Drawing.Point(239, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(832, 38);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label20.TabIndex = 20;
            this.label20.Text = "Eliminar usuario";
            // 
            // btnEliminarUsuario
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.btnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(320, 32);
<<<<<<< HEAD
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(106, 41);
=======
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(97, 31);
>>>>>>> FERNANDO
=======
            this.btnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(480, 49);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(145, 47);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.btnEliminarUsuario.TabIndex = 16;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click_1);
            // 
            // txtIdEliminar
            // 
<<<<<<< HEAD
            this.txtIdEliminar.Location = new System.Drawing.Point(133, 63);
<<<<<<< HEAD
            this.txtIdEliminar.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtIdEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txtIdEliminar.Location = new System.Drawing.Point(200, 97);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(48, 26);
            this.txtIdEliminar.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel4, 13);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.txtIDatualizar);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btnActualizarUsuario);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtActualizarOcupacion);
            this.panel4.Controls.Add(this.txtActualizarCorreo);
            this.panel4.Controls.Add(this.txtActualizarInstitucion);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtActualizarNombre);
            this.panel4.Controls.Add(this.txtActualizarTelefono);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.txtActualizarDireccion);
            this.panel4.Controls.Add(this.label14);
<<<<<<< HEAD
            this.panel4.Location = new System.Drawing.Point(39, 28);
<<<<<<< HEAD
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel4.SetRowSpan(this.panel4, 10);
            this.panel4.Size = new System.Drawing.Size(486, 256);
=======
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel4.SetRowSpan(this.panel4, 10);
            this.panel4.Size = new System.Drawing.Size(477, 256);
>>>>>>> FERNANDO
=======
            this.panel4.Location = new System.Drawing.Point(59, 43);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel4.SetRowSpan(this.panel4, 10);
            this.panel4.Size = new System.Drawing.Size(715, 394);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.panel4.TabIndex = 23;
            // 
            // label22
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(247, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
<<<<<<< HEAD
            this.label22.Size = new System.Drawing.Size(37, 24);
=======
            this.label22.Size = new System.Drawing.Size(28, 24);
>>>>>>> FERNANDO
=======
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label22.Location = new System.Drawing.Point(371, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 38);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label22.TabIndex = 20;
            this.label22.Text = "ID";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label17
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(237, -1);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
<<<<<<< HEAD
            this.label17.Size = new System.Drawing.Size(209, 49);
=======
            this.label17.Size = new System.Drawing.Size(200, 49);
>>>>>>> FERNANDO
=======
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.Location = new System.Drawing.Point(356, -1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(300, 77);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label17.TabIndex = 19;
            this.label17.Text = "Ingrese el numero de ID del usuario que desea actualizar ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIDatualizar
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtIDatualizar.Location = new System.Drawing.Point(288, 51);
            this.txtIDatualizar.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtIDatualizar.Location = new System.Drawing.Point(279, 53);
            this.txtIDatualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.txtIDatualizar.Location = new System.Drawing.Point(419, 82);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtIDatualizar.Name = "txtIDatualizar";
            this.txtIDatualizar.Size = new System.Drawing.Size(36, 26);
            this.txtIDatualizar.TabIndex = 18;
            // 
            // label15
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 83);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
<<<<<<< HEAD
            this.label15.Size = new System.Drawing.Size(76, 22);
=======
            this.label15.Size = new System.Drawing.Size(67, 22);
>>>>>>> FERNANDO
=======
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.Location = new System.Drawing.Point(19, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 36);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label15.TabIndex = 5;
            this.label15.Text = "Direccion";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnActualizarUsuario
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnActualizarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.btnActualizarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.btnActualizarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
            this.btnActualizarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(309, 198);
<<<<<<< HEAD
            this.btnActualizarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(116, 45);
=======
            this.btnActualizarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(107, 45);
>>>>>>> FERNANDO
=======
            this.btnActualizarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarUsuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnActualizarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(464, 304);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(160, 71);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.btnActualizarUsuario.TabIndex = 17;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = false;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click_1);
            // 
            // label18
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 183);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 21);
=======
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 179);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 25);
>>>>>>> FERNANDO
=======
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label18.Location = new System.Drawing.Point(19, 276);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(216, 40);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label18.TabIndex = 10;
            this.label18.Text = "Institucion";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label16
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(247, 132);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
<<<<<<< HEAD
            this.label16.Size = new System.Drawing.Size(158, 22);
=======
            this.label16.Size = new System.Drawing.Size(149, 22);
>>>>>>> FERNANDO
=======
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(371, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(223, 35);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label16.TabIndex = 7;
            this.label16.Text = "Telefono";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarOcupacion
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtActualizarOcupacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarOcupacion.Location = new System.Drawing.Point(13, 161);
            this.txtActualizarOcupacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarOcupacion.Name = "txtActualizarOcupacion";
            this.txtActualizarOcupacion.Size = new System.Drawing.Size(192, 20);
=======
            this.txtActualizarOcupacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarOcupacion.Location = new System.Drawing.Point(13, 161);
            this.txtActualizarOcupacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActualizarOcupacion.Name = "txtActualizarOcupacion";
            this.txtActualizarOcupacion.Size = new System.Drawing.Size(183, 20);
>>>>>>> FERNANDO
=======
            this.txtActualizarOcupacion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarOcupacion.Location = new System.Drawing.Point(19, 247);
            this.txtActualizarOcupacion.Name = "txtActualizarOcupacion";
            this.txtActualizarOcupacion.Size = new System.Drawing.Size(272, 26);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtActualizarOcupacion.TabIndex = 8;
            // 
            // txtActualizarCorreo
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtActualizarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarCorreo.Location = new System.Drawing.Point(247, 108);
            this.txtActualizarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarCorreo.Name = "txtActualizarCorreo";
            this.txtActualizarCorreo.Size = new System.Drawing.Size(192, 20);
=======
            this.txtActualizarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarCorreo.Location = new System.Drawing.Point(247, 108);
            this.txtActualizarCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActualizarCorreo.Name = "txtActualizarCorreo";
            this.txtActualizarCorreo.Size = new System.Drawing.Size(183, 20);
>>>>>>> FERNANDO
=======
            this.txtActualizarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarCorreo.Location = new System.Drawing.Point(371, 166);
            this.txtActualizarCorreo.Name = "txtActualizarCorreo";
            this.txtActualizarCorreo.Size = new System.Drawing.Size(272, 26);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtActualizarCorreo.TabIndex = 11;
            // 
            // txtActualizarInstitucion
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtActualizarInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarInstitucion.Location = new System.Drawing.Point(13, 213);
            this.txtActualizarInstitucion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarInstitucion.Name = "txtActualizarInstitucion";
            this.txtActualizarInstitucion.Size = new System.Drawing.Size(192, 20);
=======
            this.txtActualizarInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarInstitucion.Location = new System.Drawing.Point(13, 213);
            this.txtActualizarInstitucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActualizarInstitucion.Name = "txtActualizarInstitucion";
            this.txtActualizarInstitucion.Size = new System.Drawing.Size(183, 20);
>>>>>>> FERNANDO
=======
            this.txtActualizarInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarInstitucion.Location = new System.Drawing.Point(19, 328);
            this.txtActualizarInstitucion.Name = "txtActualizarInstitucion";
            this.txtActualizarInstitucion.Size = new System.Drawing.Size(272, 26);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtActualizarInstitucion.TabIndex = 4;
            // 
            // label12
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
<<<<<<< HEAD
            this.label12.Size = new System.Drawing.Size(116, 17);
=======
            this.label12.Size = new System.Drawing.Size(107, 17);
>>>>>>> FERNANDO
=======
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(38, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 28);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label12.TabIndex = 0;
            this.label12.Text = "Editar usuario";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtActualizarNombre
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtActualizarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarNombre.Location = new System.Drawing.Point(13, 60);
            this.txtActualizarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarNombre.Name = "txtActualizarNombre";
            this.txtActualizarNombre.Size = new System.Drawing.Size(192, 20);
=======
            this.txtActualizarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarNombre.Location = new System.Drawing.Point(13, 60);
            this.txtActualizarNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActualizarNombre.Name = "txtActualizarNombre";
            this.txtActualizarNombre.Size = new System.Drawing.Size(183, 20);
>>>>>>> FERNANDO
=======
            this.txtActualizarNombre.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarNombre.Location = new System.Drawing.Point(19, 92);
            this.txtActualizarNombre.Name = "txtActualizarNombre";
            this.txtActualizarNombre.Size = new System.Drawing.Size(272, 26);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtActualizarNombre.TabIndex = 2;
            // 
            // txtActualizarTelefono
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtActualizarTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarTelefono.Location = new System.Drawing.Point(247, 161);
            this.txtActualizarTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarTelefono.Name = "txtActualizarTelefono";
            this.txtActualizarTelefono.Size = new System.Drawing.Size(192, 20);
=======
            this.txtActualizarTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarTelefono.Location = new System.Drawing.Point(247, 161);
            this.txtActualizarTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActualizarTelefono.Name = "txtActualizarTelefono";
            this.txtActualizarTelefono.Size = new System.Drawing.Size(183, 20);
>>>>>>> FERNANDO
=======
            this.txtActualizarTelefono.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarTelefono.Location = new System.Drawing.Point(371, 247);
            this.txtActualizarTelefono.Name = "txtActualizarTelefono";
            this.txtActualizarTelefono.Size = new System.Drawing.Size(272, 26);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtActualizarTelefono.TabIndex = 15;
            // 
            // label13
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
<<<<<<< HEAD
            this.label13.Size = new System.Drawing.Size(153, 20);
=======
            this.label13.Size = new System.Drawing.Size(144, 20);
>>>>>>> FERNANDO
=======
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.Location = new System.Drawing.Point(19, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 33);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label13.TabIndex = 1;
            this.label13.Text = "Nombre y apellido";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label19
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(247, 83);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
<<<<<<< HEAD
            this.label19.Size = new System.Drawing.Size(153, 22);
=======
            this.label19.Size = new System.Drawing.Size(144, 22);
>>>>>>> FERNANDO
=======
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label19.Location = new System.Drawing.Point(371, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(216, 36);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label19.TabIndex = 14;
            this.label19.Text = "Correo Electronico";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarDireccion
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtActualizarDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarDireccion.Location = new System.Drawing.Point(13, 108);
            this.txtActualizarDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarDireccion.Name = "txtActualizarDireccion";
            this.txtActualizarDireccion.Size = new System.Drawing.Size(192, 20);
=======
            this.txtActualizarDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarDireccion.Location = new System.Drawing.Point(13, 108);
            this.txtActualizarDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActualizarDireccion.Name = "txtActualizarDireccion";
            this.txtActualizarDireccion.Size = new System.Drawing.Size(183, 20);
>>>>>>> FERNANDO
=======
            this.txtActualizarDireccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarDireccion.Location = new System.Drawing.Point(19, 166);
            this.txtActualizarDireccion.Name = "txtActualizarDireccion";
            this.txtActualizarDireccion.Size = new System.Drawing.Size(272, 26);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.txtActualizarDireccion.TabIndex = 6;
            // 
            // label14
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 127);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
<<<<<<< HEAD
            this.label14.Size = new System.Drawing.Size(153, 27);
=======
            this.label14.Size = new System.Drawing.Size(144, 27);
>>>>>>> FERNANDO
=======
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.Location = new System.Drawing.Point(19, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 43);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.label14.TabIndex = 3;
            this.label14.Text = "Ocupacion";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.tlpMostrarUsuario);
            this.Mostrar.Location = new System.Drawing.Point(4, 34);
<<<<<<< HEAD
<<<<<<< HEAD
            this.Mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(2);
=======
            this.Mostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
            this.Mostrar.Size = new System.Drawing.Size(525, 410);
=======
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(3);
            this.Mostrar.Size = new System.Drawing.Size(792, 652);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.Mostrar.TabIndex = 2;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            // 
            // tlpMostrarUsuario
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.tlpMostrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.tlpMostrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> FERNANDO
            this.tlpMostrarUsuario.ColumnCount = 4;
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
<<<<<<< HEAD
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tlpMostrarUsuario.Controls.Add(this.dgvMostrarUser, 1, 2);
            this.tlpMostrarUsuario.Controls.Add(this.btnMostrar, 2, 0);
            this.tlpMostrarUsuario.Location = new System.Drawing.Point(2, 2);
            this.tlpMostrarUsuario.Margin = new System.Windows.Forms.Padding(2);
=======
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpMostrarUsuario.Controls.Add(this.dgvMostrarUser, 1, 2);
            this.tlpMostrarUsuario.Controls.Add(this.btnMostrar, 2, 0);
            this.tlpMostrarUsuario.Location = new System.Drawing.Point(2, 2);
            this.tlpMostrarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.tlpMostrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMostrarUsuario.ColumnCount = 4;
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tlpMostrarUsuario.Controls.Add(this.dgvMostrarUser, 1, 2);
            this.tlpMostrarUsuario.Controls.Add(this.btnMostrar, 2, 0);
            this.tlpMostrarUsuario.Location = new System.Drawing.Point(3, 3);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.tlpMostrarUsuario.Name = "tlpMostrarUsuario";
            this.tlpMostrarUsuario.RowCount = 4;
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMostrarUsuario.Size = new System.Drawing.Size(786, 646);
            this.tlpMostrarUsuario.TabIndex = 2;
            // 
            // dgvMostrarUser
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.dgvMostrarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.dgvMostrarUser.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.dgvMostrarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMostrarUsuario.SetColumnSpan(this.dgvMostrarUser, 2);
            this.dgvMostrarUser.Location = new System.Drawing.Point(109, 99);
            this.dgvMostrarUser.Name = "dgvMostrarUser";
            this.dgvMostrarUser.RowTemplate.Height = 28;
<<<<<<< HEAD
            this.dgvMostrarUser.Size = new System.Drawing.Size(370, 285);
=======
            this.dgvMostrarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMostrarUsuario.SetColumnSpan(this.dgvMostrarUser, 2);
            this.dgvMostrarUser.Location = new System.Drawing.Point(73, 64);
            this.dgvMostrarUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrarUser.Name = "dgvMostrarUser";
            this.dgvMostrarUser.RowTemplate.Height = 28;
            this.dgvMostrarUser.Size = new System.Drawing.Size(373, 285);
>>>>>>> FERNANDO
=======
            this.dgvMostrarUser.Size = new System.Drawing.Size(560, 438);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.dgvMostrarUser.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (5)))), ((int) (((byte) (29)))), ((int) (((byte) (64)))));
            this.btnMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnMostrar.Location = new System.Drawing.Point(307, 2);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnMostrar.Location = new System.Drawing.Point(311, 2);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
            this.btnMostrar.Location = new System.Drawing.Point(467, 3);
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(202, 54);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Usuarios";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.tabControl1);
<<<<<<< HEAD
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(2);
=======
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> FERNANDO
=======
>>>>>>> parent of 4fb5165 (:zap:EventosCasiCompleto)
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Mostrar.ResumeLayout(false);
            this.tlpMostrarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIDatualizar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtActualizarOcupacion;
        private System.Windows.Forms.TextBox txtActualizarCorreo;
        private System.Windows.Forms.TextBox txtActualizarInstitucion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtActualizarNombre;
        private System.Windows.Forms.TextBox txtActualizarTelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtActualizarDireccion;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Button btnGuardarQR;
        private System.Windows.Forms.Button btnGenerarQR;

        private System.Windows.Forms.Button btnMostrar;

        private System.Windows.Forms.DataGridView dgvMostrarUser;

        private System.Windows.Forms.TableLayoutPanel tlpMostrarUsuario;

        private System.Windows.Forms.TextBox txt;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.TextBox txtUsuarioID;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Button btnCrearUsuario;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOcupacion;

        private System.Windows.Forms.TextBox txtNombreUsuarios;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage Mostrar;

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}