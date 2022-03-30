
namespace IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.result = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.result_box = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(213, 349);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 23);
            this.result.TabIndex = 1;
            this.result.Text = "Resultado";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(21, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Nome:";
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(21, 53);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(34, 13);
            this.sexo.TabIndex = 2;
            this.sexo.Text = "Sexo:";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(21, 79);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(34, 13);
            this.peso.TabIndex = 3;
            this.peso.Text = "Peso:";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(21, 105);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(37, 13);
            this.altura.TabIndex = 4;
            this.altura.Text = "Altura:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(66, 24);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(66, 50);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(100, 20);
            this.txt_sexo.TabIndex = 6;
            this.txt_sexo.TextChanged += new System.EventHandler(this.txt_sexo_TextChanged);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(66, 102);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 7;
            this.txt_altura.TextChanged += new System.EventHandler(this.txt_altura_TextChanged);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(66, 76);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 8;
            this.txt_peso.TextChanged += new System.EventHandler(this.txt_peso_TextChanged);
            // 
            // result_box
            // 
            this.result_box.AutoSize = true;
            this.result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_box.Location = new System.Drawing.Point(128, 177);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(213, 80);
            this.result_box.TabIndex = 9;
            this.result_box.Text = "                                                   \r\n                            " +
    "       \r\n                                                   \r\n                  " +
    "                ";
            this.result_box.Click += new System.EventHandler(this.result_box_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(213, 349);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 23);
            this.limpar.TabIndex = 0;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 384);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.name);
            this.Controls.Add(this.result);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label result_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button limpar;
    }
}

