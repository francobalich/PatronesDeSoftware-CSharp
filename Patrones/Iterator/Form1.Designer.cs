using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PdC_04_Iterator
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this._Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPrimero = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this._btnSiguiente = new System.Windows.Forms.Button();
            this._btnPrimero = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _Button1
            // 
            this._Button1.Location = new System.Drawing.Point(264, 33);
            this._Button1.Name = "_Button1";
            this._Button1.Size = new System.Drawing.Size(75, 23);
            this._Button1.TabIndex = 0;
            this._Button1.Text = "Agregar";
            this._Button1.UseVisualStyleBackColor = true;
            this._Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(31, 15);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Item";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(122, 35);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 258);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 15);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Primero";
            // 
            // txtPrimero
            // 
            this.txtPrimero.Location = new System.Drawing.Point(93, 258);
            this.txtPrimero.Name = "txtPrimero";
            this.txtPrimero.Size = new System.Drawing.Size(100, 20);
            this.txtPrimero.TabIndex = 5;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(93, 299);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 7;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(26, 299);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 15);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Actual";
            // 
            // _btnSiguiente
            // 
            this._btnSiguiente.Location = new System.Drawing.Point(199, 294);
            this._btnSiguiente.Name = "_btnSiguiente";
            this._btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this._btnSiguiente.TabIndex = 8;
            this._btnSiguiente.Text = "Siguiente";
            this._btnSiguiente.UseVisualStyleBackColor = true;
            this._btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // _btnPrimero
            // 
            this._btnPrimero.Location = new System.Drawing.Point(199, 258);
            this._btnPrimero.Name = "_btnPrimero";
            this._btnPrimero.Size = new System.Drawing.Size(75, 23);
            this._btnPrimero.TabIndex = 9;
            this._btnPrimero.Text = "Primero";
            this._btnPrimero.UseVisualStyleBackColor = true;
            this._btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 173);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 402);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this._btnPrimero);
            this.Controls.Add(this._btnSiguiente);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtPrimero);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button _Button1;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button1 != null)
                {
                    _Button1.Click -= Button1_Click;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += Button1_Click;
                }
            }
        }

        internal Label Label1;
        internal TextBox TextBox1;
        internal Label Label2;
        internal TextBox txtPrimero;
        internal TextBox TextBox2;
        internal Label Label3;
        private Button _btnSiguiente;

        internal Button btnSiguiente
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSiguiente;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSiguiente != null)
                {
                    _btnSiguiente.Click -= btnSiguiente_Click;
                }

                _btnSiguiente = value;
                if (_btnSiguiente != null)
                {
                    _btnSiguiente.Click += btnSiguiente_Click;
                }
            }
        }

        private Button _btnPrimero;
        private ListBox listBox1;

        internal Button btnPrimero
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPrimero;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPrimero != null)
                {
                    _btnPrimero.Click -= btnPrimero_Click;
                }

                _btnPrimero = value;
                if (_btnPrimero != null)
                {
                    _btnPrimero.Click += btnPrimero_Click;
                }
            }
        }
    }
}