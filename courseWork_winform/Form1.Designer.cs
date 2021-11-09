
namespace courseWork_winform
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.read_data = new System.Windows.Forms.Button();
            this.write_data = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pop_source = new System.Windows.Forms.Button();
            this.put_in_reciever = new System.Windows.Forms.Button();
            this.num_to_put = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.make_stack_rs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rs_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // read_data
            // 
            this.read_data.Location = new System.Drawing.Point(47, 24);
            this.read_data.Name = "read_data";
            this.read_data.Size = new System.Drawing.Size(75, 23);
            this.read_data.TabIndex = 1;
            this.read_data.Text = "Read Data";
            this.read_data.UseVisualStyleBackColor = true;
            this.read_data.Click += new System.EventHandler(this.read_data_Click);
            // 
            // write_data
            // 
            this.write_data.Location = new System.Drawing.Point(139, 24);
            this.write_data.Name = "write_data";
            this.write_data.Size = new System.Drawing.Size(75, 23);
            this.write_data.TabIndex = 2;
            this.write_data.Text = "Write Data";
            this.write_data.UseVisualStyleBackColor = true;
            this.write_data.Click += new System.EventHandler(this.write_data_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(260, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(541, 459);
            this.listBox1.TabIndex = 3;
            this.listBox1.Tag = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.id_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rs_textbox);
            this.panel1.Controls.Add(this.make_stack_rs);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.num_to_put);
            this.panel1.Controls.Add(this.put_in_reciever);
            this.panel1.Controls.Add(this.pop_source);
            this.panel1.Controls.Add(this.read_data);
            this.panel1.Controls.Add(this.write_data);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 450);
            this.panel1.TabIndex = 4;
            // 
            // pop_source
            // 
            this.pop_source.Location = new System.Drawing.Point(20, 139);
            this.pop_source.Name = "pop_source";
            this.pop_source.Size = new System.Drawing.Size(110, 23);
            this.pop_source.TabIndex = 5;
            this.pop_source.Text = "Pop Source";
            this.pop_source.UseVisualStyleBackColor = true;
            this.pop_source.Click += new System.EventHandler(this.pop_source_Click);
            // 
            // put_in_reciever
            // 
            this.put_in_reciever.Location = new System.Drawing.Point(20, 187);
            this.put_in_reciever.Name = "put_in_reciever";
            this.put_in_reciever.Size = new System.Drawing.Size(110, 20);
            this.put_in_reciever.TabIndex = 5;
            this.put_in_reciever.Text = "Put in Reciever";
            this.put_in_reciever.UseVisualStyleBackColor = true;
            this.put_in_reciever.Click += new System.EventHandler(this.put_in_reciever_Click);
            // 
            // num_to_put
            // 
            this.num_to_put.Location = new System.Drawing.Point(136, 187);
            this.num_to_put.Name = "num_to_put";
            this.num_to_put.Size = new System.Drawing.Size(100, 20);
            this.num_to_put.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "From S to R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // make_stack_rs
            // 
            this.make_stack_rs.Location = new System.Drawing.Point(67, 284);
            this.make_stack_rs.Name = "make_stack_rs";
            this.make_stack_rs.Size = new System.Drawing.Size(124, 23);
            this.make_stack_rs.TabIndex = 6;
            this.make_stack_rs.Text = "Make Stack R or S";
            this.make_stack_rs.UseVisualStyleBackColor = true;
            this.make_stack_rs.Click += new System.EventHandler(this.make_stack_rs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input \"R\" or \"S\":";
            // 
            // rs_textbox
            // 
            this.rs_textbox.Location = new System.Drawing.Point(185, 325);
            this.rs_textbox.Name = "rs_textbox";
            this.rs_textbox.Size = new System.Drawing.Size(41, 20);
            this.rs_textbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(47, 325);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(41, 20);
            this.id_textbox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button read_data;
        private System.Windows.Forms.Button write_data;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pop_source;
        private System.Windows.Forms.TextBox num_to_put;
        private System.Windows.Forms.Button put_in_reciever;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rs_textbox;
        private System.Windows.Forms.Button make_stack_rs;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label label2;
    }
}

