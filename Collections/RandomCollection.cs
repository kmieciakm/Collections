using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections {
    public class RandomCollection<T> : IEnumerable<T> {
        private List<T> Items { get; }

        public IEnumerator<T> GetEnumerator() {
            for (int i = 0; i < Items.Count; i++) {
                yield return Get();
            }
        }

        public IEnumerable<T> GetRandom(int amount) {
            for (int i = 0; i < amount; i++) {
                yield return Get();
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public RandomCollection(List<T> items) {
            Items = items;
        }

        public T Get() {
            var rand = new Random();
            return Items.ElementAt(rand.Next(0, Items.Count()));
        }
    }
}
