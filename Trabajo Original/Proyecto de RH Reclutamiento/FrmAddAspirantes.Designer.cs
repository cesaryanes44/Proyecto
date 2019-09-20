namespace Proyecto_de_RH_Reclutamiento
{
    partial class FrmAddAspirantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label experienciaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label identidadLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label salarioqueQuiereGanarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAspirantes));
            this.listaDeAspirantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeAspirantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.listaDeNivelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeTitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeAreasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.experienciaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.identidadTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.salarioqueQuiereGanarTextBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            direccionLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            experienciaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            identidadLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            salarioqueQuiereGanarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAspirantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAspirantesBindingNavigator)).BeginInit();
            this.listaDeAspirantesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeNivelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAreasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(27, 220);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 3;
            direccionLabel.Text = "Direccion:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(27, 106);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 5;
            edadLabel.Text = "Edad:";
            // 
            // experienciaLabel
            // 
            experienciaLabel.AutoSize = true;
            experienciaLabel.Location = new System.Drawing.Point(27, 165);
            experienciaLabel.Name = "experienciaLabel";
            experienciaLabel.Size = new System.Drawing.Size(65, 13);
            experienciaLabel.TabIndex = 7;
            experienciaLabel.Text = "Experiencia:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 56);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 9;
            idLabel.Text = "Id:";
            // 
            // identidadLabel
            // 
            identidadLabel.AutoSize = true;
            identidadLabel.Location = new System.Drawing.Point(27, 135);
            identidadLabel.Name = "identidadLabel";
            identidadLabel.Size = new System.Drawing.Size(54, 13);
            identidadLabel.TabIndex = 11;
            identidadLabel.Text = "Identidad:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(27, 83);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 15;
            nombreLabel.Text = "Nombre:";
            // 
            // salarioqueQuiereGanarLabel
            // 
            salarioqueQuiereGanarLabel.AutoSize = true;
            salarioqueQuiereGanarLabel.Location = new System.Drawing.Point(27, 194);
            salarioqueQuiereGanarLabel.Name = "salarioqueQuiereGanarLabel";
            salarioqueQuiereGanarLabel.Size = new System.Drawing.Size(39, 13);
            salarioqueQuiereGanarLabel.TabIndex = 17;
            salarioqueQuiereGanarLabel.Text = "Salario";
            // 
            // listaDeAspirantesBindingSource
            // 
            this.listaDeAspirantesBindingSource.DataSource = typeof(Proyecto_de_RH_Reclutamiento.Modelos.Aspirantes);
            // 
            // listaDeAspirantesBindingNavigator
            // 
            this.listaDeAspirantesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaDeAspirantesBindingNavigator.BindingSource = this.listaDeAspirantesBindingSource;
            this.listaDeAspirantesBindingNavigator.CountItem = null;
            this.listaDeAspirantesBindingNavigator.DeleteItem = null;
            this.listaDeAspirantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripLabel1});
            this.listaDeAspirantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaDeAspirantesBindingNavigator.MoveFirstItem = null;
            this.listaDeAspirantesBindingNavigator.MoveLastItem = null;
            this.listaDeAspirantesBindingNavigator.MoveNextItem = null;
            this.listaDeAspirantesBindingNavigator.MovePreviousItem = null;
            this.listaDeAspirantesBindingNavigator.Name = "listaDeAspirantesBindingNavigator";
            this.listaDeAspirantesBindingNavigator.PositionItem = null;
            this.listaDeAspirantesBindingNavigator.Size = new System.Drawing.Size(360, 25);
            this.listaDeAspirantesBindingNavigator.TabIndex = 0;
            this.listaDeAspirantesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(165, 22);
            this.toolStripLabel1.Text = "AGREGAR NUEVO ASPIRANTE";
            // 
            // listaDeNivelBindingSource
            // 
            this.listaDeNivelBindingSource.DataSource = typeof(Proyecto_de_RH_Reclutamiento.Modelos.NivelIngles);
            // 
            // listaDeTitulosBindingSource
            // 
            this.listaDeTitulosBindingSource.DataSource = typeof(Proyecto_de_RH_Reclutamiento.Modelos.Titulo);
            // 
            // listaDeAreasBindingSource
            // 
            this.listaDeAreasBindingSource.DataSource = typeof(Proyecto_de_RH_Reclutamiento.Modelos.Area);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeAspirantesBindingSource, "Direccion", true));
            this.direccionTextBox.Enabled = false;
            this.direccionTextBox.Location = new System.Drawing.Point(159, 217);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 4;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeAspirantesBindingSource, "Edad", true));
            this.edadTextBox.Enabled = false;
            this.edadTextBox.Location = new System.Drawing.Point(159, 106);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(100, 20);
            this.edadTextBox.TabIndex = 6;
            // 
            // experienciaTextBox
            // 
            this.experienciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeAspirantesBindingSource, "Experiencia", true));
            this.experienciaTextBox.Enabled = false;
            this.experienciaTextBox.Location = new System.Drawing.Point(159, 162);
            this.experienciaTextBox.Name = "experienciaTextBox";
            this.experienciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.experienciaTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeAspirantesBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(159, 53);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 10;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // identidadTextBox
            // 
            this.identidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeAspirantesBindingSource, "Identidad", true));
            this.identidadTextBox.Enabled = false;
            this.identidadTextBox.Location = new System.Drawing.Point(159, 132);
            this.identidadTextBox.Name = "identidadTextBox";
            this.identidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.identidadTextBox.TabIndex = 12;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeAspirantesBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(159, 80);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 16;
            // 
            // salarioqueQuiereGanarTextBox
            // 
            this.salarioqueQuiereGanarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeAspirantesBindingSource, "SalarioqueQuiereGanar", true));
            this.salarioqueQuiereGanarTextBox.Enabled = false;
            this.salarioqueQuiereGanarTextBox.Location = new System.Drawing.Point(159, 191);
            this.salarioqueQuiereGanarTextBox.Name = "salarioqueQuiereGanarTextBox";
            this.salarioqueQuiereGanarTextBox.Size = new System.Drawing.Size(100, 20);
            this.salarioqueQuiereGanarTextBox.TabIndex = 18;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaDeAspirantesBindingSource, "NivelInglesId", true));
            this.comboBox3.DataSource = this.listaDeNivelBindingSource;
            this.comboBox3.DisplayMember = "Nivel";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(139, 246);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(131, 21);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.ValueMember = "Id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nivel de Ingles:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Area:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaDeAspirantesBindingSource, "AreaId", true));
            this.comboBox2.DataSource = this.listaDeAreasBindingSource;
            this.comboBox2.DisplayMember = "Descripcion";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(75, 303);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.ValueMember = "Id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Titulo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaDeAspirantesBindingSource, "TituloId", true));
            this.comboBox1.DataSource = this.listaDeTitulosBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmAddAspirantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 369);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(experienciaLabel);
            this.Controls.Add(this.experienciaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(identidadLabel);
            this.Controls.Add(this.identidadTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(salarioqueQuiereGanarLabel);
            this.Controls.Add(this.salarioqueQuiereGanarTextBox);
            this.Controls.Add(this.listaDeAspirantesBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddAspirantes";
            this.Text = "Adicionar Aspirante";
            this.Load += new System.EventHandler(this.FrmAddAspirantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAspirantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAspirantesBindingNavigator)).EndInit();
            this.listaDeAspirantesBindingNavigator.ResumeLayout(false);
            this.listaDeAspirantesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeNivelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAreasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaDeAspirantesBindingSource;
        private System.Windows.Forms.BindingNavigator listaDeAspirantesBindingNavigator;
        private System.Windows.Forms.BindingSource listaDeNivelBindingSource;
        private System.Windows.Forms.BindingSource listaDeTitulosBindingSource;
        private System.Windows.Forms.BindingSource listaDeAreasBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox experienciaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox identidadTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox salarioqueQuiereGanarTextBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}