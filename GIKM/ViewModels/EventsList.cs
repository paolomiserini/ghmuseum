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
            for (int i = 0; i < 25; i++)
            {
                Events.Add(new Event { Title = "prova prova prova prova", ShortDescription = "description long long long long", Date = "01/01/2020-31/12/2020", id = i, imageUrl= "https://img.gettextbooks.com/pi//9781490292878" });
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
            singleEvent.Description = "Long Long Long Long Long &#10;Descrption proviamo a scrivere una cos molta lunga e&#10; vediamo che cosa succede per fare questa cosa";
            singleEvent.Date = "01/01/2020-31/12/2020";
            singleEvent.id = _eventId;
            singleEvent.imageUrl = "http://www.paolomiserini.it/public/pic.jpg";
        }

    }

}
