﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using ServiceFournis;
namespace BiblioWcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICompteService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICompteService 
    {



        [OperationContract]
        [WebGet(UriTemplate = "/LogInEtudiant/{nomUtilisateur}/{motPasse}",ResponseFormat =WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        CompteEtudiant seConnecterEtudaint(String nomUtilisateur, String motPasse);

        [OperationContract]
        [WebGet( UriTemplate = "/LogInEnsiegnant/{nomUtilisateur}/{motPasse}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        CompteEnseigant seConnecterEnseignant(String nomUtilisateur, String motPasse);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SignInEtudiant", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Boolean creeCompteEtudiant(CompteEtudiant c);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SignInEnseignant", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Boolean creeCompteEnseignant(CompteEnseigant c);

        /*[OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SetEtudiant", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Boolean modifierCompteEtudiant(CompteEtudiant ancien, CompteEtudiant compteNouveau);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SetEnseignant", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Boolean modifierCompteEnseignant(CompteEnseigant ancien, CompteEnseigant compteNouveau);*/

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/CheckUserName/{nomUtilisateur}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Boolean verifierNomUtilisateur(String nomUtilisateur);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/CheckCardNumbre/{numeroCarte}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Boolean verifierNumeroCarte(String numeroCarte);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/CheckSeqNumbre/{matrecule}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Boolean verifierMatrecule(String matrecule);
    }
}
