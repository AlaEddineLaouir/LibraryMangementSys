﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioUIEmprenteur.ServiceWcf {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWcf.ServiceClientCompte")]
    public interface ServiceClientCompte {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/seConnecterEtudaint", ReplyAction="http://tempuri.org/ServiceClientCompte/seConnecterEtudaintResponse")]
        ServiceFournis.CompteEtudiant seConnecterEtudaint(string nomUtilisateur, string motPasse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/seConnecterEtudaint", ReplyAction="http://tempuri.org/ServiceClientCompte/seConnecterEtudaintResponse")]
        System.Threading.Tasks.Task<ServiceFournis.CompteEtudiant> seConnecterEtudaintAsync(string nomUtilisateur, string motPasse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/seConnecterEnseignant", ReplyAction="http://tempuri.org/ServiceClientCompte/seConnecterEnseignantResponse")]
        ServiceFournis.CompteEnseigant seConnecterEnseignant(string nomUtilisateur, string motPasse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/seConnecterEnseignant", ReplyAction="http://tempuri.org/ServiceClientCompte/seConnecterEnseignantResponse")]
        System.Threading.Tasks.Task<ServiceFournis.CompteEnseigant> seConnecterEnseignantAsync(string nomUtilisateur, string motPasse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/creeCompteEtudiant", ReplyAction="http://tempuri.org/ServiceClientCompte/creeCompteEtudiantResponse")]
        bool creeCompteEtudiant(ServiceFournis.CompteEtudiant c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/creeCompteEtudiant", ReplyAction="http://tempuri.org/ServiceClientCompte/creeCompteEtudiantResponse")]
        System.Threading.Tasks.Task<bool> creeCompteEtudiantAsync(ServiceFournis.CompteEtudiant c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/creeCompteEnseignant", ReplyAction="http://tempuri.org/ServiceClientCompte/creeCompteEnseignantResponse")]
        bool creeCompteEnseignant(ServiceFournis.CompteEnseigant c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/creeCompteEnseignant", ReplyAction="http://tempuri.org/ServiceClientCompte/creeCompteEnseignantResponse")]
        System.Threading.Tasks.Task<bool> creeCompteEnseignantAsync(ServiceFournis.CompteEnseigant c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/modifierCompteEtudiant", ReplyAction="http://tempuri.org/ServiceClientCompte/modifierCompteEtudiantResponse")]
        bool modifierCompteEtudiant(string nomUtilisateur, ServiceFournis.CompteEtudiant compteNouveau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/modifierCompteEtudiant", ReplyAction="http://tempuri.org/ServiceClientCompte/modifierCompteEtudiantResponse")]
        System.Threading.Tasks.Task<bool> modifierCompteEtudiantAsync(string nomUtilisateur, ServiceFournis.CompteEtudiant compteNouveau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/modifierCompteEnseignant", ReplyAction="http://tempuri.org/ServiceClientCompte/modifierCompteEnseignantResponse")]
        bool modifierCompteEnseignant(string nomUtilisateur, ServiceFournis.CompteEnseigant compteNouveau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/modifierCompteEnseignant", ReplyAction="http://tempuri.org/ServiceClientCompte/modifierCompteEnseignantResponse")]
        System.Threading.Tasks.Task<bool> modifierCompteEnseignantAsync(string nomUtilisateur, ServiceFournis.CompteEnseigant compteNouveau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/verifierNomUtilisateur", ReplyAction="http://tempuri.org/ServiceClientCompte/verifierNomUtilisateurResponse")]
        bool verifierNomUtilisateur(string nomUtilisateur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/verifierNomUtilisateur", ReplyAction="http://tempuri.org/ServiceClientCompte/verifierNomUtilisateurResponse")]
        System.Threading.Tasks.Task<bool> verifierNomUtilisateurAsync(string nomUtilisateur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/verifierNumeroCarte", ReplyAction="http://tempuri.org/ServiceClientCompte/verifierNumeroCarteResponse")]
        bool verifierNumeroCarte(string numeroCarte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/verifierNumeroCarte", ReplyAction="http://tempuri.org/ServiceClientCompte/verifierNumeroCarteResponse")]
        System.Threading.Tasks.Task<bool> verifierNumeroCarteAsync(string numeroCarte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/verifierMatrecule", ReplyAction="http://tempuri.org/ServiceClientCompte/verifierMatreculeResponse")]
        bool verifierMatrecule(string matrecule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientCompte/verifierMatrecule", ReplyAction="http://tempuri.org/ServiceClientCompte/verifierMatreculeResponse")]
        System.Threading.Tasks.Task<bool> verifierMatreculeAsync(string matrecule);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceClientCompteChannel : BiblioUIEmprenteur.ServiceWcf.ServiceClientCompte, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClientCompteClient : System.ServiceModel.ClientBase<BiblioUIEmprenteur.ServiceWcf.ServiceClientCompte>, BiblioUIEmprenteur.ServiceWcf.ServiceClientCompte {
        
        public ServiceClientCompteClient() {
        }
        
        public ServiceClientCompteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClientCompteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClientCompteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClientCompteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceFournis.CompteEtudiant seConnecterEtudaint(string nomUtilisateur, string motPasse) {
            return base.Channel.seConnecterEtudaint(nomUtilisateur, motPasse);
        }
        
        public System.Threading.Tasks.Task<ServiceFournis.CompteEtudiant> seConnecterEtudaintAsync(string nomUtilisateur, string motPasse) {
            return base.Channel.seConnecterEtudaintAsync(nomUtilisateur, motPasse);
        }
        
        public ServiceFournis.CompteEnseigant seConnecterEnseignant(string nomUtilisateur, string motPasse) {
            return base.Channel.seConnecterEnseignant(nomUtilisateur, motPasse);
        }
        
        public System.Threading.Tasks.Task<ServiceFournis.CompteEnseigant> seConnecterEnseignantAsync(string nomUtilisateur, string motPasse) {
            return base.Channel.seConnecterEnseignantAsync(nomUtilisateur, motPasse);
        }
        
        public bool creeCompteEtudiant(ServiceFournis.CompteEtudiant c) {
            return base.Channel.creeCompteEtudiant(c);
        }
        
        public System.Threading.Tasks.Task<bool> creeCompteEtudiantAsync(ServiceFournis.CompteEtudiant c) {
            return base.Channel.creeCompteEtudiantAsync(c);
        }
        
        public bool creeCompteEnseignant(ServiceFournis.CompteEnseigant c) {
            return base.Channel.creeCompteEnseignant(c);
        }
        
        public System.Threading.Tasks.Task<bool> creeCompteEnseignantAsync(ServiceFournis.CompteEnseigant c) {
            return base.Channel.creeCompteEnseignantAsync(c);
        }
        
        public bool modifierCompteEtudiant(string nomUtilisateur, ServiceFournis.CompteEtudiant compteNouveau) {
            return base.Channel.modifierCompteEtudiant(nomUtilisateur, compteNouveau);
        }
        
        public System.Threading.Tasks.Task<bool> modifierCompteEtudiantAsync(string nomUtilisateur, ServiceFournis.CompteEtudiant compteNouveau) {
            return base.Channel.modifierCompteEtudiantAsync(nomUtilisateur, compteNouveau);
        }
        
        public bool modifierCompteEnseignant(string nomUtilisateur, ServiceFournis.CompteEnseigant compteNouveau) {
            return base.Channel.modifierCompteEnseignant(nomUtilisateur, compteNouveau);
        }
        
        public System.Threading.Tasks.Task<bool> modifierCompteEnseignantAsync(string nomUtilisateur, ServiceFournis.CompteEnseigant compteNouveau) {
            return base.Channel.modifierCompteEnseignantAsync(nomUtilisateur, compteNouveau);
        }
        
        public bool verifierNomUtilisateur(string nomUtilisateur) {
            return base.Channel.verifierNomUtilisateur(nomUtilisateur);
        }
        
        public System.Threading.Tasks.Task<bool> verifierNomUtilisateurAsync(string nomUtilisateur) {
            return base.Channel.verifierNomUtilisateurAsync(nomUtilisateur);
        }
        
        public bool verifierNumeroCarte(string numeroCarte) {
            return base.Channel.verifierNumeroCarte(numeroCarte);
        }
        
        public System.Threading.Tasks.Task<bool> verifierNumeroCarteAsync(string numeroCarte) {
            return base.Channel.verifierNumeroCarteAsync(numeroCarte);
        }
        
        public bool verifierMatrecule(string matrecule) {
            return base.Channel.verifierMatrecule(matrecule);
        }
        
        public System.Threading.Tasks.Task<bool> verifierMatreculeAsync(string matrecule) {
            return base.Channel.verifierMatreculeAsync(matrecule);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWcf.ServiceClientOvrague")]
    public interface ServiceClientOvrague {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/chercherOuvrague", ReplyAction="http://tempuri.org/ServiceClientOvrague/chercherOuvragueResponse")]
        ServiceFournis.Ouvrague[] chercherOuvrague(string motCle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/chercherOuvrague", ReplyAction="http://tempuri.org/ServiceClientOvrague/chercherOuvragueResponse")]
        System.Threading.Tasks.Task<ServiceFournis.Ouvrague[]> chercherOuvragueAsync(string motCle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/reserverOuvrague", ReplyAction="http://tempuri.org/ServiceClientOvrague/reserverOuvragueResponse")]
        bool reserverOuvrague(string nomUtilisateur, string codeOuvrague);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/reserverOuvrague", ReplyAction="http://tempuri.org/ServiceClientOvrague/reserverOuvragueResponse")]
        System.Threading.Tasks.Task<bool> reserverOuvragueAsync(string nomUtilisateur, string codeOuvrague);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/attendreOuvrague", ReplyAction="http://tempuri.org/ServiceClientOvrague/attendreOuvragueResponse")]
        bool attendreOuvrague(string nomUtilisateur, string codeOuvrague);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/attendreOuvrague", ReplyAction="http://tempuri.org/ServiceClientOvrague/attendreOuvragueResponse")]
        System.Threading.Tasks.Task<bool> attendreOuvragueAsync(string nomUtilisateur, string codeOuvrague);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/mesReservation", ReplyAction="http://tempuri.org/ServiceClientOvrague/mesReservationResponse")]
        ServiceFournis.Emprinte[] mesReservation(string nomUtilisateur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/mesReservation", ReplyAction="http://tempuri.org/ServiceClientOvrague/mesReservationResponse")]
        System.Threading.Tasks.Task<ServiceFournis.Emprinte[]> mesReservationAsync(string nomUtilisateur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/mesEmprintes", ReplyAction="http://tempuri.org/ServiceClientOvrague/mesEmprintesResponse")]
        ServiceFournis.Emprinte[] mesEmprintes(string nomUtilisateur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/mesEmprintes", ReplyAction="http://tempuri.org/ServiceClientOvrague/mesEmprintesResponse")]
        System.Threading.Tasks.Task<ServiceFournis.Emprinte[]> mesEmprintesAsync(string nomUtilisateur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/verifierCodeOuvrague", ReplyAction="http://tempuri.org/ServiceClientOvrague/verifierCodeOuvragueResponse")]
        string verifierCodeOuvrague(string Code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceClientOvrague/verifierCodeOuvrague", ReplyAction="http://tempuri.org/ServiceClientOvrague/verifierCodeOuvragueResponse")]
        System.Threading.Tasks.Task<string> verifierCodeOuvragueAsync(string Code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceClientOvragueChannel : BiblioUIEmprenteur.ServiceWcf.ServiceClientOvrague, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClientOvragueClient : System.ServiceModel.ClientBase<BiblioUIEmprenteur.ServiceWcf.ServiceClientOvrague>, BiblioUIEmprenteur.ServiceWcf.ServiceClientOvrague {
        
        public ServiceClientOvragueClient() {
        }
        
        public ServiceClientOvragueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClientOvragueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClientOvragueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClientOvragueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceFournis.Ouvrague[] chercherOuvrague(string motCle) {
            return base.Channel.chercherOuvrague(motCle);
        }
        
        public System.Threading.Tasks.Task<ServiceFournis.Ouvrague[]> chercherOuvragueAsync(string motCle) {
            return base.Channel.chercherOuvragueAsync(motCle);
        }
        
        public bool reserverOuvrague(string nomUtilisateur, string codeOuvrague) {
            return base.Channel.reserverOuvrague(nomUtilisateur, codeOuvrague);
        }
        
        public System.Threading.Tasks.Task<bool> reserverOuvragueAsync(string nomUtilisateur, string codeOuvrague) {
            return base.Channel.reserverOuvragueAsync(nomUtilisateur, codeOuvrague);
        }
        
        public bool attendreOuvrague(string nomUtilisateur, string codeOuvrague) {
            return base.Channel.attendreOuvrague(nomUtilisateur, codeOuvrague);
        }
        
        public System.Threading.Tasks.Task<bool> attendreOuvragueAsync(string nomUtilisateur, string codeOuvrague) {
            return base.Channel.attendreOuvragueAsync(nomUtilisateur, codeOuvrague);
        }
        
        public ServiceFournis.Emprinte[] mesReservation(string nomUtilisateur) {
            return base.Channel.mesReservation(nomUtilisateur);
        }
        
        public System.Threading.Tasks.Task<ServiceFournis.Emprinte[]> mesReservationAsync(string nomUtilisateur) {
            return base.Channel.mesReservationAsync(nomUtilisateur);
        }
        
        public ServiceFournis.Emprinte[] mesEmprintes(string nomUtilisateur) {
            return base.Channel.mesEmprintes(nomUtilisateur);
        }
        
        public System.Threading.Tasks.Task<ServiceFournis.Emprinte[]> mesEmprintesAsync(string nomUtilisateur) {
            return base.Channel.mesEmprintesAsync(nomUtilisateur);
        }
        
        public string verifierCodeOuvrague(string Code) {
            return base.Channel.verifierCodeOuvrague(Code);
        }
        
        public System.Threading.Tasks.Task<string> verifierCodeOuvragueAsync(string Code) {
            return base.Channel.verifierCodeOuvragueAsync(Code);
        }
    }
}
