using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9 {
    class Person {

        //instance variables
        private string name;

        //constructors
        public Person() { }
        public Person(string name) {
            this.name = name;
        }
        public Person(Person obj) {
            name = obj.name;
        }

        //methods
        /// <summary>
        /// Returns name
        /// </summary>
        /// <returns>name value as string</returns>
        public string GetName() {
            return name;
        }

        /// <summary>
        /// sets name
        /// </summary>
        /// <param name="name">value to pass into name</param>
        public void SetName(string name) {
            this.name = name;
        }

        /// <summary>
        /// returns object as string
        /// </summary>
        /// <returns>value of name</returns>
        public override string ToString() {
            return name;
        }

        /// <summary>
        /// Compares two person objects
        /// </summary>
        /// <param name="obj">Other person object</param>
        /// <returns>true if equal</returns>
        public bool Equals (Person obj) {
            return name == obj.name;
        }

    }
}
