using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service
{
    public interface IService
    {
        bool login(string name, string password);
        bool register(string firstName, string lastName, string CNP, string affiliation, string website, string email, string username, string password);
        string validateRegister(string CNP, string username, string email);
        void AddListener(string CNP);
        void AddAuthor(long CNP, string affiliation);
        void AddParticipant(string Username, string Password, string FirstName, string LastName, string Email);
        void AddRegularMember(string CNP, string Affiliation, string Website, string FirstName, string LastName, string email, string Username, string Password);

        void AddSpeaker(string CNP, string affiliation, string username, string password, string firstName, string lastName, string email);

        //void RemoveListener()

        void UpdateListener(string CNP);
        void UpdateAuthor(long CNP, string affiliation);
        void UpdateParticipant(string Username, string Password, string FirstName, string LastName, string Email);
        void UpdatePcMember(string CNP, string Affiliation, string Website);
        void UpdateSpeaker(string CNP, string affiliation, string username, string password, string firstName, string lastName, string email);

        List<Listener> FindAllListeners();

    }
}
