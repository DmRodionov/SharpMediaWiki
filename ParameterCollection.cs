﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Claymore.SharpMediaWiki
{
    public class ParameterCollection : IEnumerable<KeyValuePair<string, string>>
    {
        private readonly Dictionary<string, string> _parameters;

        public ParameterCollection()
        {
            _parameters = new Dictionary<string, string>();
            _parameters.Add("format", "xml");
        }

        public ParameterCollection(ParameterCollection copy)
        {
            _parameters = new Dictionary<string, string>(copy._parameters);
        }

        public void Add(string key, string value)
        {
            if (key == "action")
            {
                throw new ArgumentException("You can't add 'action' as a parameter.");
            }
            _parameters.Add(key, value);
        }

        public void Add(string key)
        {
            _parameters.Add(key, "1");
        }

        public void Clear()
        {
            _parameters.Clear();
            _parameters.Add("format", "xml");
        }

        #region IEnumerable<KeyValuePair<string,string>> Members

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        #endregion
    }
}
