using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTemplate
{
    public class GettingStartedModel : INotifyPropertyChanged
    {
        private string? image;
        private string? headerMessage;

        public string? Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }

        public string? HeaderMessage
        {
            get { return headerMessage; }
            set
            {
                headerMessage = value;
                OnPropertyChanged("HeaderMessage");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class FormatModel : INotifyPropertyChanged
    {
        private string? _content;
        private string? _icon;
        private bool _isSelected;

        public string? Content
        {
            get => _content;
            set
            {
                if (_content != value)
                {
                    _content = value;
                    OnPropertyChanged(nameof(Content));
                }
            }
        }

        public string? Icon
        {
            get => _icon;
            set
            {
                if (_icon != value)
                {
                    _icon = value!;
                    OnPropertyChanged(nameof(Image));
                }
            }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                }
            }
        }

        public FormatModel(string? toneContent, string? fontIcon, bool isSelected)
        {
            Content = toneContent;
            Icon = fontIcon;
            IsSelected = isSelected;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class LengthModel : INotifyPropertyChanged
    {
        public string? LengthContent { get; set; }

        public LengthModel(string? lengthContent, bool isSelected)
        {
            LengthContent = lengthContent;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ToneModel : INotifyPropertyChanged
    {
        private string? toneContent;

        public string? ToneContent
        {
            get => toneContent;
            set
            {
                if (toneContent != value)
                {
                    toneContent = value!;
                    OnPropertyChanged(nameof(ToneContent));
                }
            }
        }

        public ToneModel(string? toneContent, bool isSelected)
        {
            ToneContent = toneContent;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
