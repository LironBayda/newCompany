using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCompany
{
   public class Story
    {
        private string _title;
        private string _body;
        private string _visualStyle;

        public Story(string title, string body)
        {
            _title = title;
            _body = body;
            SetVisualStyle("David");
        }

        public void  SetTitle(string title)
        {
            _title = title;
        }

        public void SetBody(string body)
        {
            _body = body;
        }

        public void SetVisualStyle(string visualStyle)
        {
            _visualStyle = visualStyle;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetBody()
        {
            return _body;
        }

        public string GetVisualStyle()
        {
            return _visualStyle;
        }

        public override string ToString()
        {
            return base.ToString()+ $"_body: {_body} _title: {_title} _visualStyle: {_visualStyle}";
        }
    }
}