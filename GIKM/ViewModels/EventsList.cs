using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace GIKM.ViewModels
{
    // Contiene il singolo evento caricato dall'API
    public class Event
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Date { get; set; }
        public string imageUrl { get; set; }
        public string formType { get; set; }
                      
    }

    public class EventsList : BindableObject
    {
        private ObservableCollection<Event> _events;
        private string _pageName;

        public EventsList(string pagename)
        {
            _pageName = pagename;
            Events = new ObservableCollection<Event>();
            LoadEvents(_pageName);

        }

        public ObservableCollection<Event> Events
        {
            get { return _events; }
            set
            {
                _events = value;
                OnPropertyChanged();

            }
        }

        private void LoadEvents(string _pageEventType)
        {
            switch (_pageEventType)
            {
                case AppConstants.ZUBK:
                    // Nel caso non fossero presenti eventi andra' caricato un record vuoto con il testo
                    // che non esistono eventi aperti
                    Events.Add(new Event { Title = "ZUBK No event open", ShortDescription = "Non esistono eventi", Date = "# - #", id = 0, imageUrl = "https://img.gettextbooks.com/pi//9781490292878", formType = _pageEventType });

                    //for (int i = 0; i < 25; i++)
                    //{
                    //    Events.Add(new Event { Title = "ZUBK prova prova prova prova", ShortDescription = "description long long long long", Date = "01/01/2020-31/12/2020", id = i, imageUrl = "https://img.gettextbooks.com/pi//9781490292878" , formType=_pageEventType});
                    //}
                    break;
                case AppConstants.GIKM:
                    for (int i = 0; i < 25; i++)
                    {
                        Events.Add(new Event { Title = "GIKM prova prova prova prova", ShortDescription = "description short to tetsting the app with multiline", Date = "01/01/2020-31/12/2020", id = i, imageUrl = "https://img.gettextbooks.com/pi//9781490292878", formType=_pageEventType });
                    }
                    break;
                default:
                    break;
            }

        }
    }

    public class SingleEvent : BindableObject
    {
        private Event _event;

        public SingleEvent(int _id)
        {
            singleEvent = new Event();
            LoadSingleEvent(_id);
        }

        public Event singleEvent
        {
            get { return _event; }
            set
            {
                _event = value;
                OnPropertyChanged();
            }
        }
        private void LoadSingleEvent(int _eventId)
        {
            singleEvent.Title = "prova prova prova prova";
            singleEvent.ShortDescription = "description short";
            singleEvent.Description = "Long Long Long Long Long &#10;Descrption proviamo a scrivere una cos molta lunga e&#10; vediamo che cosa succede per fare questa cosa deve eseere ancora molto piu lunga di quello che sembra perche altrimenti non se ne esce e non riesco a vedere come si formatta la stringa allinterno del coldice";
            singleEvent.Date = "01/01/2020-31/12/2020";
            singleEvent.id = _eventId;
            singleEvent.imageUrl = "http://gelmusey.ru/wp-content/uploads/2020/06/%D0%BF%D0%BB%D0%B0%D0%BA%D0%B0%D1%82_%D0%BF%D0%BE%D0%B1%D0%B5%D0%B4%D0%B0_%D0%BC%D0%B0%D0%BB%D0%B5%D0%BD%D1%8C%D0%BA%D0%B8%D0%B9-1170x420.jpg";
        }

    }

}
