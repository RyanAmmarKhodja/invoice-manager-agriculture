using StockIt_2.services.GestionProduit;

namespace StockIt_2.view.user_controls
{
    partial class uc_bon
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            fadresse = new TextBox();
            facture = new TextBox();
            bl = new TextBox();
            ftel = new TextBox();
            nis = new TextBox();
            nif = new TextBox();
            ai = new TextBox();
            rc = new TextBox();
            fprenom = new TextBox();
            fnom = new TextBox();
            tadresse = new TextBox();
            ttel = new TextBox();
            matricule = new TextBox();
            label14 = new Label();
            tprenom = new TextBox();
            tnom = new TextBox();
            label17 = new Label();
            label18 = new Label();
            choisir_fournisseur = new Button();
            button1 = new Button();
            button3 = new Button();
            prix_unitaire = new TextBox();
            label19 = new Label();
            label22 = new Label();
            poids = new TextBox();
            label23 = new Label();
            nombre = new TextBox();
            label24 = new Label();
            label25 = new Label();
            total_transport = new Label();
            cout_transport = new TextBox();
            label21 = new Label();
            imprimer = new Button();
            label26 = new Label();
            crc = new TextBox();
            label27 = new Label();
            cadresse = new TextBox();
            label28 = new Label();
            cai = new TextBox();
            label29 = new Label();
            cnif = new TextBox();
            label30 = new Label();
            cnis = new TextBox();
            label31 = new Label();
            ajouter_produit = new Button();
            combo = new ComboBox();
            gestionProduitBindingSource = new BindingSource(components);
            total_des = new Label();
            button4 = new Button();
            tg = new Label();
            total_ttc = new Label();
            total_tpv = new Label();
            total_general = new Label();
            coords_email = new TextBox();
            label20 = new Label();
            coords_tel = new TextBox();
            label32 = new Label();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)gestionProduitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // fadresse
            // 
            fadresse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            fadresse.Location = new Point(140, 91);
            fadresse.Name = "fadresse";
            fadresse.Size = new Size(727, 31);
            fadresse.TabIndex = 66;
            // 
            // facture
            // 
            facture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            facture.Location = new Point(140, 490);
            facture.Name = "facture";
            facture.Size = new Size(302, 31);
            facture.TabIndex = 64;
            // 
            // bl
            // 
            bl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bl.Location = new Point(140, 430);
            bl.Name = "bl";
            bl.Size = new Size(302, 31);
            bl.TabIndex = 62;
            // 
            // ftel
            // 
            ftel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ftel.Location = new Point(140, 374);
            ftel.Name = "ftel";
            ftel.Size = new Size(302, 31);
            ftel.TabIndex = 60;
            // 
            // nis
            // 
            nis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nis.Location = new Point(140, 318);
            nis.Name = "nis";
            nis.Size = new Size(302, 31);
            nis.TabIndex = 58;
            // 
            // nif
            // 
            nif.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nif.Location = new Point(140, 259);
            nif.Name = "nif";
            nif.Size = new Size(302, 31);
            nif.TabIndex = 56;
            // 
            // ai
            // 
            ai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ai.Location = new Point(140, 202);
            ai.Name = "ai";
            ai.Size = new Size(302, 31);
            ai.TabIndex = 54;
            // 
            // rc
            // 
            rc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rc.Location = new Point(140, 145);
            rc.Name = "rc";
            rc.Size = new Size(302, 31);
            rc.TabIndex = 52;
            // 
            // fprenom
            // 
            fprenom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            fprenom.Location = new Point(569, 42);
            fprenom.Name = "fprenom";
            fprenom.Size = new Size(298, 31);
            fprenom.TabIndex = 50;
            // 
            // fnom
            // 
            fnom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            fnom.Location = new Point(140, 42);
            fnom.Name = "fnom";
            fnom.Size = new Size(298, 31);
            fnom.TabIndex = 48;
            // 
            // tadresse
            // 
            tadresse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tadresse.Location = new Point(140, 63);
            tadresse.Name = "tadresse";
            tadresse.Size = new Size(727, 31);
            tadresse.TabIndex = 77;
            // 
            // ttel
            // 
            ttel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ttel.Location = new Point(140, 169);
            ttel.Name = "ttel";
            ttel.Size = new Size(302, 31);
            ttel.TabIndex = 75;
            // 
            // matricule
            // 
            matricule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            matricule.Location = new Point(140, 116);
            matricule.Name = "matricule";
            matricule.Size = new Size(302, 31);
            matricule.TabIndex = 73;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(176, 696);
            label14.Name = "label14";
            label14.Size = new Size(290, 32);
            label14.TabIndex = 71;
            label14.Text = "Ajouter un transporteur";
            // 
            // tprenom
            // 
            tprenom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tprenom.Location = new Point(569, 13);
            tprenom.Name = "tprenom";
            tprenom.Size = new Size(315, 31);
            tprenom.TabIndex = 70;
            // 
            // tnom
            // 
            tnom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tnom.Location = new Point(140, 13);
            tnom.Name = "tnom";
            tnom.Size = new Size(302, 31);
            tnom.TabIndex = 68;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.Location = new Point(176, 72);
            label17.Name = "label17";
            label17.Size = new Size(275, 32);
            label17.TabIndex = 78;
            label17.Text = "Ajouter un fournisseur";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(86, 20);
            label18.Name = "label18";
            label18.Size = new Size(403, 32);
            label18.TabIndex = 79;
            label18.Text = "Accueil/Achats/Créer un bon d'achat";
            // 
            // choisir_fournisseur
            // 
            choisir_fournisseur.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            choisir_fournisseur.Font = new Font("Segoe UI", 10F);
            choisir_fournisseur.Location = new Point(794, 69);
            choisir_fournisseur.Name = "choisir_fournisseur";
            choisir_fournisseur.Size = new Size(275, 41);
            choisir_fournisseur.TabIndex = 80;
            choisir_fournisseur.Text = "Choisir un fournisseur";
            choisir_fournisseur.UseVisualStyleBackColor = true;
            choisir_fournisseur.Click += choisir_fournisseur_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(794, 693);
            button1.Name = "button1";
            button1.Size = new Size(275, 41);
            button1.TabIndex = 81;
            button1.Text = "Choisir un transporteur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(31, 19);
            button3.Name = "button3";
            button3.Size = new Size(43, 34);
            button3.TabIndex = 83;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // prix_unitaire
            // 
            prix_unitaire.Location = new Point(200, 1191);
            prix_unitaire.Name = "prix_unitaire";
            prix_unitaire.Size = new Size(124, 31);
            prix_unitaire.TabIndex = 94;
            prix_unitaire.TextChanged += prix_unitaire_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(29, 1191);
            label19.Name = "label19";
            label19.Size = new Size(160, 32);
            label19.TabIndex = 93;
            label19.Text = "Prix par unité:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label22.Location = new Point(31, 987);
            label22.Name = "label22";
            label22.Size = new Size(158, 32);
            label22.TabIndex = 88;
            label22.Text = "Commande: ";
            // 
            // poids
            // 
            poids.Location = new Point(200, 1145);
            poids.Name = "poids";
            poids.Size = new Size(124, 31);
            poids.TabIndex = 87;
            poids.TextChanged += poids_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(29, 1145);
            label23.Name = "label23";
            label23.Size = new Size(175, 32);
            label23.TabIndex = 86;
            label23.Text = "Poids (en Kgs) :";
            // 
            // nombre
            // 
            nombre.Location = new Point(200, 1102);
            nombre.Name = "nombre";
            nombre.Size = new Size(124, 31);
            nombre.TabIndex = 85;
            nombre.TextChanged += nombre_TextChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F);
            label24.Location = new Point(31, 1099);
            label24.Name = "label24";
            label24.Size = new Size(114, 32);
            label24.TabIndex = 84;
            label24.Text = "Nombre :";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F);
            label25.Location = new Point(31, 1048);
            label25.Name = "label25";
            label25.Size = new Size(154, 32);
            label25.TabIndex = 95;
            label25.Text = "Désignation :";
            // 
            // total_transport
            // 
            total_transport.AutoSize = true;
            total_transport.Font = new Font("Segoe UI", 12F);
            total_transport.Location = new Point(541, 1243);
            total_transport.Name = "total_transport";
            total_transport.Size = new Size(91, 32);
            total_transport.TabIndex = 97;
            total_transport.Text = "Total :  ";
            // 
            // cout_transport
            // 
            cout_transport.Location = new Point(327, 1246);
            cout_transport.Name = "cout_transport";
            cout_transport.Size = new Size(117, 31);
            cout_transport.TabIndex = 99;
            cout_transport.TextChanged += tpv_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.Location = new Point(29, 1245);
            label21.Name = "label21";
            label21.Size = new Size(276, 32);
            label21.TabIndex = 98;
            label21.Text = "Coût transport par unité:";
            // 
            // imprimer
            // 
            imprimer.Font = new Font("Segoe UI", 10F);
            imprimer.Location = new Point(708, 1820);
            imprimer.Name = "imprimer";
            imprimer.Size = new Size(275, 41);
            imprimer.TabIndex = 100;
            imprimer.Text = "Imprimer";
            imprimer.UseVisualStyleBackColor = true;
            imprimer.Click += imprimer_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label26.Location = new Point(31, 1327);
            label26.Name = "label26";
            label26.Size = new Size(180, 32);
            label26.TabIndex = 103;
            label26.Text = "Coordonnées :";
            // 
            // crc
            // 
            crc.Location = new Point(200, 1473);
            crc.Name = "crc";
            crc.Size = new Size(450, 31);
            crc.TabIndex = 102;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F);
            label27.Location = new Point(31, 1470);
            label27.Name = "label27";
            label27.Size = new Size(55, 32);
            label27.TabIndex = 101;
            label27.Text = "RC :";
            // 
            // cadresse
            // 
            cadresse.Location = new Point(200, 1529);
            cadresse.Name = "cadresse";
            cadresse.Size = new Size(450, 31);
            cadresse.TabIndex = 105;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F);
            label28.Location = new Point(31, 1526);
            label28.Name = "label28";
            label28.Size = new Size(109, 32);
            label28.TabIndex = 104;
            label28.Text = "Adresse :";
            // 
            // cai
            // 
            cai.Location = new Point(200, 1579);
            cai.Name = "cai";
            cai.Size = new Size(450, 31);
            cai.TabIndex = 107;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 12F);
            label29.Location = new Point(31, 1576);
            label29.Name = "label29";
            label29.Size = new Size(47, 32);
            label29.TabIndex = 106;
            label29.Text = "AI :";
            // 
            // cnif
            // 
            cnif.Location = new Point(200, 1631);
            cnif.Name = "cnif";
            cnif.Size = new Size(450, 31);
            cnif.TabIndex = 109;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F);
            label30.Location = new Point(31, 1630);
            label30.Name = "label30";
            label30.Size = new Size(62, 32);
            label30.TabIndex = 108;
            label30.Text = "NIF :";
            // 
            // cnis
            // 
            cnis.Location = new Point(200, 1683);
            cnis.Name = "cnis";
            cnis.Size = new Size(450, 31);
            cnis.TabIndex = 111;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F);
            label31.Location = new Point(31, 1682);
            label31.Name = "label31";
            label31.Size = new Size(63, 32);
            label31.TabIndex = 110;
            label31.Text = "NIS :";
            // 
            // ajouter_produit
            // 
            ajouter_produit.Location = new Point(544, 1049);
            ajouter_produit.Name = "ajouter_produit";
            ajouter_produit.Size = new Size(123, 34);
            ajouter_produit.TabIndex = 112;
            ajouter_produit.Text = "Ajouter produit";
            ajouter_produit.UseVisualStyleBackColor = true;
            ajouter_produit.Click += ajouter_produit_Click;
            // 
            // combo
            // 
            combo.AllowDrop = true;
            combo.FormattingEnabled = true;
            combo.Location = new Point(200, 1049);
            combo.Name = "combo";
            combo.Size = new Size(320, 33);
            combo.TabIndex = 113;
            // 
            // gestionProduitBindingSource
            // 
            gestionProduitBindingSource.DataSource = typeof(GestionProduit);
            // 
            // total_des
            // 
            total_des.AutoSize = true;
            total_des.Font = new Font("Segoe UI", 12F);
            total_des.Location = new Point(360, 1194);
            total_des.Name = "total_des";
            total_des.Size = new Size(84, 32);
            total_des.TabIndex = 114;
            total_des.Text = "Total : ";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F);
            button4.Location = new Point(217, 1324);
            button4.Name = "button4";
            button4.Size = new Size(275, 41);
            button4.TabIndex = 115;
            button4.Text = "Enregistrer les modifications";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tg
            // 
            tg.AutoSize = true;
            tg.Font = new Font("Segoe UI", 12F);
            tg.Location = new Point(564, 1284);
            tg.Name = "tg";
            tg.Size = new Size(54, 32);
            tg.TabIndex = 116;
            tg.Text = "TG :";
            // 
            // total_ttc
            // 
            total_ttc.AutoSize = true;
            total_ttc.Font = new Font("Segoe UI", 12F);
            total_ttc.Location = new Point(439, 1194);
            total_ttc.Name = "total_ttc";
            total_ttc.Size = new Size(27, 32);
            total_ttc.TabIndex = 117;
            total_ttc.Text = "0";
            // 
            // total_tpv
            // 
            total_tpv.AutoSize = true;
            total_tpv.Font = new Font("Segoe UI", 12F);
            total_tpv.Location = new Point(620, 1243);
            total_tpv.Name = "total_tpv";
            total_tpv.Size = new Size(27, 32);
            total_tpv.TabIndex = 118;
            total_tpv.Text = "0";
            // 
            // total_general
            // 
            total_general.AutoSize = true;
            total_general.Font = new Font("Segoe UI", 12F);
            total_general.Location = new Point(620, 1284);
            total_general.Name = "total_general";
            total_general.Size = new Size(27, 32);
            total_general.TabIndex = 119;
            total_general.Text = "0";
            // 
            // coords_email
            // 
            coords_email.Location = new Point(200, 1423);
            coords_email.Name = "coords_email";
            coords_email.Size = new Size(450, 31);
            coords_email.TabIndex = 121;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(31, 1420);
            label20.Name = "label20";
            label20.Size = new Size(83, 32);
            label20.TabIndex = 120;
            label20.Text = "Email :";
            // 
            // coords_tel
            // 
            coords_tel.Location = new Point(200, 1377);
            coords_tel.Name = "coords_tel";
            coords_tel.Size = new Size(450, 31);
            coords_tel.TabIndex = 123;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 12F);
            label32.Location = new Point(31, 1374);
            label32.Name = "label32";
            label32.Size = new Size(56, 32);
            label32.TabIndex = 122;
            label32.Text = "Tel :";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel10);
            kryptonPanel1.Controls.Add(kryptonLabel9);
            kryptonPanel1.Controls.Add(kryptonLabel8);
            kryptonPanel1.Controls.Add(kryptonLabel7);
            kryptonPanel1.Controls.Add(kryptonLabel6);
            kryptonPanel1.Controls.Add(kryptonLabel5);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(fnom);
            kryptonPanel1.Controls.Add(fprenom);
            kryptonPanel1.Controls.Add(fadresse);
            kryptonPanel1.Controls.Add(rc);
            kryptonPanel1.Controls.Add(ai);
            kryptonPanel1.Controls.Add(nif);
            kryptonPanel1.Controls.Add(nis);
            kryptonPanel1.Controls.Add(ftel);
            kryptonPanel1.Controls.Add(bl);
            kryptonPanel1.Controls.Add(facture);
            kryptonPanel1.Location = new Point(176, 113);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            kryptonPanel1.Size = new Size(893, 541);
            kryptonPanel1.TabIndex = 124;
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel10.Location = new Point(13, 492);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(123, 29);
            kryptonLabel10.TabIndex = 74;
            kryptonLabel10.Values.Text = "N° FACTURE :";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel9.Location = new Point(13, 432);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(62, 29);
            kryptonLabel9.TabIndex = 73;
            kryptonLabel9.Values.Text = "N°BL :";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel8.Location = new Point(13, 376);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(49, 29);
            kryptonLabel8.TabIndex = 72;
            kryptonLabel8.Values.Text = "TEL :";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel7.Location = new Point(13, 320);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(50, 29);
            kryptonLabel7.TabIndex = 71;
            kryptonLabel7.Values.Text = "NIS :";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel6.Location = new Point(13, 261);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(49, 29);
            kryptonLabel6.TabIndex = 70;
            kryptonLabel6.Values.Text = "NIF :";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel5.Location = new Point(13, 204);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(38, 29);
            kryptonLabel5.TabIndex = 69;
            kryptonLabel5.Values.Text = "AI :";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel4.Location = new Point(13, 145);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(44, 29);
            kryptonLabel4.TabIndex = 68;
            kryptonLabel4.Values.Text = "RC :";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel3.Location = new Point(13, 93);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(86, 29);
            kryptonLabel3.TabIndex = 67;
            kryptonLabel3.Values.Text = "Adresse :";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel2.Location = new Point(476, 44);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(85, 29);
            kryptonLabel2.TabIndex = 51;
            kryptonLabel2.Values.Text = "Prénom :";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel1.Location = new Point(13, 44);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(62, 29);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Nom :";
            kryptonLabel1.Click += kryptonLabel1_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel2.Controls.Add(kryptonLabel15);
            kryptonPanel2.Controls.Add(kryptonLabel14);
            kryptonPanel2.Controls.Add(kryptonLabel13);
            kryptonPanel2.Controls.Add(kryptonLabel11);
            kryptonPanel2.Controls.Add(kryptonLabel12);
            kryptonPanel2.Controls.Add(tnom);
            kryptonPanel2.Controls.Add(tprenom);
            kryptonPanel2.Controls.Add(tadresse);
            kryptonPanel2.Controls.Add(matricule);
            kryptonPanel2.Controls.Add(ttel);
            kryptonPanel2.Location = new Point(176, 740);
            kryptonPanel2.Margin = new Padding(50, 3, 50, 3);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(893, 279);
            kryptonPanel2.TabIndex = 125;
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel15.Location = new Point(13, 118);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(98, 29);
            kryptonLabel15.TabIndex = 80;
            kryptonLabel15.Values.Text = "Matricule :";
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel14.Location = new Point(14, 171);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Size = new Size(49, 29);
            kryptonLabel14.TabIndex = 79;
            kryptonLabel14.Values.Text = "TEL :";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel13.Location = new Point(13, 65);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(86, 29);
            kryptonLabel13.TabIndex = 78;
            kryptonLabel13.Values.Text = "Adresse :";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel11.Location = new Point(476, 15);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(85, 29);
            kryptonLabel11.TabIndex = 70;
            kryptonLabel11.Values.Text = "Prénom :";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel12.Location = new Point(13, 15);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(62, 29);
            kryptonLabel12.TabIndex = 69;
            kryptonLabel12.Values.Text = "Nom :";
            // 
            // uc_bon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(kryptonPanel2);
            Controls.Add(label17);
            Controls.Add(kryptonPanel1);
            Controls.Add(coords_tel);
            Controls.Add(label32);
            Controls.Add(coords_email);
            Controls.Add(label20);
            Controls.Add(total_general);
            Controls.Add(total_tpv);
            Controls.Add(total_ttc);
            Controls.Add(tg);
            Controls.Add(button4);
            Controls.Add(total_des);
            Controls.Add(combo);
            Controls.Add(ajouter_produit);
            Controls.Add(cnis);
            Controls.Add(label31);
            Controls.Add(cnif);
            Controls.Add(label30);
            Controls.Add(cai);
            Controls.Add(label29);
            Controls.Add(choisir_fournisseur);
            Controls.Add(cadresse);
            Controls.Add(label28);
            Controls.Add(label26);
            Controls.Add(crc);
            Controls.Add(label27);
            Controls.Add(imprimer);
            Controls.Add(cout_transport);
            Controls.Add(label21);
            Controls.Add(total_transport);
            Controls.Add(label25);
            Controls.Add(prix_unitaire);
            Controls.Add(label19);
            Controls.Add(label22);
            Controls.Add(poids);
            Controls.Add(label23);
            Controls.Add(nombre);
            Controls.Add(label24);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label18);
            Controls.Add(label14);
            Margin = new Padding(50, 3, 50, 3);
            Name = "uc_bon";
            Size = new Size(1252, 1910);
            Load += uc_bon_Load;
            ((System.ComponentModel.ISupportInitialize)gestionProduitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fadresse;
        private TextBox facture;
        private TextBox bl;
        private TextBox ftel;
        private TextBox nis;
        private TextBox nif;
        private TextBox ai;
        private TextBox rc;
        private TextBox fprenom;
        private TextBox fnom;
        private TextBox tadresse;
        private TextBox ttel;
        private TextBox matricule;
        private Label label14;
        private TextBox tprenom;
        private TextBox tnom;
        private Label label17;
        private Label label18;
        private Button choisir_fournisseur;
        private Button button1;
        private Button button3;
        private TextBox prix_unitaire;
        private Label label19;
        private Label label22;
        private TextBox poids;
        private Label label23;
        private TextBox nombre;
        private Label label24;
        private TextBox designation;
        private Label label25;
        private Label total_transport;
        private TextBox cout_transport;
        private Label label21;
        private Button imprimer;
        private Label label26;
        private TextBox crc;
        private Label label27;
        private TextBox cadresse;
        private Label label28;
        private TextBox cai;
        private Label label29;
        private TextBox cnif;
        private Label label30;
        private TextBox cnis;
        private Label label31;
        private Button ajouter_produit;
        private ComboBox combo;
        private BindingSource gestionProduitBindingSource;
        private Label total_des;
        private Button button4;
        private Label tg;
        private Label total_ttc;
        private Label total_tpv;
        private Label total_general;
        private TextBox coords_email;
        private Label label20;
        private TextBox coords_tel;
        private Label label32;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
    }
}
