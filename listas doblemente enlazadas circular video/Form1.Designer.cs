namespace listas_doblemente_enlazadas_circular_video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            BTNanterior = new Button();
            LBLCanalActual = new Label();
            BTNreiniciar = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            BTNsiguiente = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Sala_acogedora_con_TV_y_plantas;
            panel1.Controls.Add(BTNanterior);
            panel1.Controls.Add(LBLCanalActual);
            panel1.Controls.Add(BTNreiniciar);
            panel1.Controls.Add(axWindowsMediaPlayer1);
            panel1.Controls.Add(BTNsiguiente);
            panel1.Location = new Point(29, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1430, 781);
            panel1.TabIndex = 0;
            // 
            // BTNanterior
            // 
            BTNanterior.Location = new Point(625, 621);
            BTNanterior.Name = "BTNanterior";
            BTNanterior.Size = new Size(75, 23);
            BTNanterior.TabIndex = 2;
            BTNanterior.Text = "◀ Anterior";
            BTNanterior.UseVisualStyleBackColor = true;
            BTNanterior.Click += btnAnterior_Click;
            // 
            // LBLCanalActual
            // 
            LBLCanalActual.AutoSize = true;
            LBLCanalActual.BackColor = SystemColors.ActiveCaptionText;
            LBLCanalActual.ForeColor = Color.Lime;
            LBLCanalActual.Location = new Point(715, 696);
            LBLCanalActual.Name = "LBLCanalActual";
            LBLCanalActual.Size = new Size(128, 15);
            LBLCanalActual.TabIndex = 5;
            LBLCanalActual.Text = "Agarrando señal carnal";
            // 
            // BTNreiniciar
            // 
            BTNreiniciar.Location = new Point(715, 621);
            BTNreiniciar.Name = "BTNreiniciar";
            BTNreiniciar.Size = new Size(75, 23);
            BTNreiniciar.TabIndex = 1;
            BTNreiniciar.Text = "↻ Reiniciar";
            BTNreiniciar.UseVisualStyleBackColor = true;
            BTNreiniciar.Click += btnReiniciar_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(314, 100);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(922, 504);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // BTNsiguiente
            // 
            BTNsiguiente.Location = new Point(807, 621);
            BTNsiguiente.Name = "BTNsiguiente";
            BTNsiguiente.Size = new Size(79, 23);
            BTNsiguiente.TabIndex = 3;
            BTNsiguiente.Text = "Siguiente ▶";
            BTNsiguiente.UseVisualStyleBackColor = true;
            BTNsiguiente.Click += BTNsiguiente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 810);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button BTNreiniciar;
        private Button BTNanterior;
        private Button BTNsiguiente;
        private Label LBLCanalActual;
    }
}
