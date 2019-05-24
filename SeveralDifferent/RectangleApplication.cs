// For each namespace?/file? you must have the necessary imports
using System;

/**/
namespace RectangleApplication {
   class Rectangle {
      //member variables
      public double length = 1;
      public double width  = 1;
      
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }

   }//end class Rectangle

   
   
}// */