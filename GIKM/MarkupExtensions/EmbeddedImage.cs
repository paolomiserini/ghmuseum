using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.MarkupExtensions
{
    [ContentProperty("ResourceId")]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            // controllo che la stringa immagine sia valorizzata
            if (String.IsNullOrWhiteSpace(ResourceId))
                return null;
            // ritorna l'immagine embedded nel progetto
            return ImageSource.FromResource(ResourceId);
        }
    }
}
