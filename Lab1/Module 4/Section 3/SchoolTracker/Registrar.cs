using System.Collections.Generic;

namespace SchoolTracker
{
    public class Registrar
    {

        public Registrar(List<IGraduate> grads)
        {
            this.grads = grads;
            grads.Add(new Student());
        }

        public List<IGraduate> grads { get; set; }

        public void graduateAll()
        {
            foreach (var grad in grads)
            {
                grad.graduate();
            }
        }
        
        
    }
}