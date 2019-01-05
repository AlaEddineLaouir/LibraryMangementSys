﻿using System;


namespace ServiceFournis
{
    [Serializable]
    public class Ouvrague
    {
        private String typeOuvrague;
        private String theme;
        private String auteur;
        private String titre;
        private String code;
        private String etat;


       

        public string TypeOuvrague { get => typeOuvrague; set => typeOuvrague = value; }
        public string Theme { get => theme; set => theme = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Code { get => code; set => code = value; }
        public String Etat { get => etat; set => etat = value; }
    }
}
