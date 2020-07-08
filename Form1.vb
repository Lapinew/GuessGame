Public Class FormPrincipale

    Private tabMots() As String 'Tableau contenant les mots possibles à deviner
    Private Const CONST_ESSAIS As Integer = 3 'Le nombre maximal d'essais auquel à droit l'utilisateur (appelé pour le reinitialiser le nombre d'essais restants lors d'une nouvelle partie)
    Private essais As Integer = 3 'Le Le nombre d'essais restants (mit a jour au fur et à mesure des tentatives et des parties)
    Private motAtrouver As String 'String contenant le mot à trouver (récupéré dans le tableau)
    Private random As New Random() 'Initialise l'objet permettant de déterminer les entiers aléatoires
    Private cptVictoire As Integer 'Compteur de victoire (pour le résumé lors de la fermeture de l'application)
    Private cptDefaite As Integer 'Compteur de defaites (pour le résumé lors de la fermeture de l'application)
    Private nbParties As Integer = 0 'Compteur du nombre de parties jouées (Utilisé pour numéroter les parties dans l'historique
    Private nbCoups As Integer = 0 'Compteur du nombre de coups tentés par l'utilisateur pour la partie en cours (utile lors de la victoire)

    ''' <summary>
    ''' Procédure permettant d'afficher la message box donnant le résumé des parties jouées (nombre victoires/defaites)
    ''' Appelée dans tout les cas ou l'application ferme
    ''' </summary>
    Private Sub msgBox_resultat()
        MessageBox.Show("Nombre de defaites : " & cptDefaite & vbCrLf & "Nombre de victoires : " & cptVictoire, "Fermeture")
    End Sub

    ''' <summary>
    ''' Procédure gérant la victoire. Affiche une boite de dialogue annoncant la victoire et invitant l'utilisateur à recommencer.
    ''' </summary>
    Private Sub motCorrect()
        If MessageBox.Show("Voulez vous rejouer ?", "VICTOIRE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Si oui
            lstHisto.Items.Add("PARTIE " & nbParties & " : VICTOIRE (" & nbCoups & " coup(s))") 'La partie est ajoutée à l'historique des parties en précisant la victoire et le nombre de coups ayant été nécéssaires
            cptVictoire = cptVictoire + 1 'Le nombre de victoires est incrémenté de 1 pour le résumé lors de la fermeture de l'application
            nouvellePartie() 'Appelle la procédure permettant de lancer une nouvelle partie
        Else msgBox_resultat() 'Si non, affiche le résumé des parties jouées (nombre victoires/defaites)
            Me.Dispose() 'Puis l'application se ferme
        End If
    End Sub

    ''' <summary>
    ''' Procédure gérant la défaite. Affiche une boite de dialogue affichant le mot qui était à deviner et invitant l'utilisateur à recommencer.
    ''' </summary>
    Private Sub motIncorrect()
        If MessageBox.Show("Le mot à deviner était " & motAtrouver & vbCrLf & "Voulez vous rejouer ?", "DEFAITE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Si oui
            lstHisto.Items.Add("PARTIE " & nbParties & " : DEFAITE") 'La partie est ajoutée à l'historique des parties en précisant la defaite
            cptDefaite = cptDefaite + 1 'Le nombre de défaites est incrémenté de 1 pour le résumé lors de la fermeture de l'application
            nouvellePartie() 'Appelle la procédure permettant de lancer une nouvelle partie
        Else msgBox_resultat() 'Si non, affiche le résumé des parties jouées (nombre victoires/defaites)
            Me.Dispose() 'Puis l'application se ferme
        End If
    End Sub

    ''' <summary>
    ''' Fonction qui renvoie une chaine de caractere resultant du mélange aléatoire des lettres de la chaine de caractère passée en parametre (mot du tableau).
    ''' </summary>
    ''' <param name="chaine">chaine de caractère à mélanger</param>
    ''' <returns>chaine de caractère mélangée</returns>
    Private Function melanger(ByVal chaine As String) As String
        Dim pos As Integer 'Position (aléatoire) ou sera placée chaque lettre dans la nouvelle chaine qui sera renvoyée
        Dim mixed As String = "" 'Chaine qui sera renvoyée
        For Each lettre In chaine 'Pour chaque lettre de la chaine en parametre
            pos = random.Next(0, mixed.Length + 1) 'Désigner une position au hasard
            mixed = mixed.Insert(pos, lettre) 'Placer la lettre à la position déterminé précédemment (dans la chaine de caractere à renvoyer)
        Next
        Return mixed
    End Function

    ''' <summary>
    ''' Fonction permettant essentiellement de mettre à jour et reinitialiser les variables nécéssaires au passage d'une partie à la suivante.
    ''' </summary>
    Private Sub nouvellePartie()
        nbCoups = 0 'Le nombre de coups tentés par l'utilisateur est remit à 0.
        nbParties = nbParties + 1 'Compteur de parties pour donner le numero des parties dans l'historique.
        essais = CONST_ESSAIS 'Le nombre d'essais restants pour l'utilisateur.
        lblNbRestant.Text = essais 'Affiche le nombre d'essais restants à l'utilisateur (initialisé juste au-dessus).
        lstPropo.Items.Clear() 'Remise à zéro de la liste des propositions de l'utilisateur émisent lors de la partie précédente.
        Dim rndnbr As Integer
        rndnbr = random.Next(0, tabMots.Length) 'Désigne au hasard un nouveau mot à trouver dans le tableau (par son indice)
        motAtrouver = tabMots(rndnbr) 'Récupération du mot dans une variable String
        lblMot.Text = melanger(motAtrouver) 'Affichage du mot mélangé pour l'utilisateur
    End Sub

    ''' <summary>
    ''' Procédure réalisant les initialisations nécéssaires au démarrage du jeu (tableau de mot) et appelant la procédure permettant de lancer une nouvelle partie.
    ''' </summary>
    Private Sub initialisation()
        tabMots = {"BONJOUR", "CASQUE", "VOITURE"}
        nouvellePartie()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'initialisation est appelée lors du premier chargement de l'application
        initialisation()
    End Sub

    ''' <summary>
    ''' Demande à l'utilisateur s'il veut réellement quitter le jeu quand il clique sur le bouton quitter. S'il repond oui, le jeu lui résume son nombre de victoires et defaites avant de fermer.
    ''' </summary>
    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If MessageBox.Show("Voulez vous vraiment quitter?", "Confirmation exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            msgBox_resultat()
            Me.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Demande à l'utilisateur s'il veut annuler la manche en cours et en recommencer une. S'il repond oui, la fonction nouvellePartie est appelée.
    ''' </summary>
    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        If MessageBox.Show("Annuler la partie en cours ?", "Recommencer une partie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            nouvellePartie()
        End If
    End Sub

    ''' <summary>
    ''' Procédure permettant à l'utilisateur de soumettre sa proposition.
    ''' </summary>
    Private Sub BtnTester_Click(sender As Object, e As EventArgs) Handles btnTester.Click
        lstPropo.Items.Add(txtSaisie.Text) 'Rajoute la tentative dans la liste des tentatives
        nbCoups = nbCoups + 1 'Dans tout les cas, le nombre de tentative de l'utilisateur pour la manche en cours est incrémenté de 1.
        If txtSaisie.Text = motAtrouver Then 'Si l'utilisateur devine le mot
            motCorrect() 'Appel la procédure gérant la victoire
        Else 'Sinon
            essais = essais - 1 'Décrémente de 1 son nombre d'essais restants
            lblNbRestant.Text = essais 'Met a jour l'affichage lui indiquant son nombre d'essais restants
        End If
        txtSaisie.Text = "" 'La zone de texte est remise à zero
        If essais = 0 Then 'Si le nombre d'essais restants de l'utilisateur atteint 0, la procédure gérant la défaite est appelée.
            motIncorrect()
        End If
    End Sub

    ''' <summary>
    ''' Procédure empechant l'utilisateur de tester sa proposition si cette derniere est nulle (désactive le bouton tester).
    ''' </summary>
    Private Sub txtSaisie_TextChanged(sender As Object, e As EventArgs) Handles txtSaisie.TextChanged
        If txtSaisie.Text.Length > 0 Then
            btnTester.Enabled = True
        Else btnTester.Enabled = False
        End If
    End Sub
End Class