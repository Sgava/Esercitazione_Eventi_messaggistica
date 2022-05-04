

using Esercitazione_Eventi_messaggistica.Publishers;
using Esercitazione_Eventi_messaggistica.Subscribers;

IPublisher email = new PublisherEmail("GMail", "email");
Subscriber utente = new Subscriber("Lillo");
utente.Subscribe(email);