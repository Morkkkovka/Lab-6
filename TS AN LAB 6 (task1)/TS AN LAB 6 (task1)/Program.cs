using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB_6__task1_
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class AbstractHandler
    {
        public void Handle(Document document)
        {
            string[] lines = document.Read();

            for (int i = lines.Length - 1; i >= 0; i--)
                document.Write(lines[i]);
        }
    }


    public abstract class Document
    {
        public abstract string Name { get; protected set; }

        public abstract void Open(string path);
        public abstract void Create(string path);
        public abstract string[] Read();
        public abstract void Write(string line);
    }
    public class RTF : Document
    {
        public override string Name { get; protected set; }

        public override void Create(string path)
        {
            throw new NotImplementedException();
        }

        public override void Open(string path)
        {
            throw new NotImplementedException();
        }

        public override string[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string line)
        {
            throw new NotImplementedException();
        }
    }

    public class DOC : Document
    {
        public override string Name { get; protected set; }

        public override void Create(string path)
        {
            throw new NotImplementedException();
        }

        public override void Open(string path)
        {
            throw new NotImplementedException();
        }

        public override string[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string line)
        {
            throw new NotImplementedException();
        }
    }
    public class ODT  : Document
    {
        public override string Name { get; protected set; }

        public override void Create(string path)
        {
            throw new NotImplementedException();
        }

        public override void Open(string path)
        {
            throw new NotImplementedException();
        }

        public override string[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string line)
        {
            throw new NotImplementedException();
        }
    }
    public class PDF : Document
    {
        public override string Name { get; protected set; }

        public override void Create(string path)
        {
            throw new NotImplementedException();
        }

        public override void Open(string path)
        {
            throw new NotImplementedException();
        }

        public override string[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string line)
        {
            throw new NotImplementedException();
        }
    }
   
}
