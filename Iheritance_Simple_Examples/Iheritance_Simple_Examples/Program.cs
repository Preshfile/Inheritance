namespace Inheritance_Simple_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                  The idea behind inheritance is the re-usability of code.
                  Inheritance allows us to reuse not only our code but that of other developers

                - The class whose members are inherited is the Base or parents Class
                - while the class that inherits the members of the base class is called - The Derived or child class

            Note:
                - The two classes Radio and TV has almost same properties and functionalities
                - Meaning there is repetition of code which translates to code redundancy
                - What we can do is create a classs that has all of the similar properties and methods
                  so that other classess in need of them can inherit from them
                - the class to be inherited from (the base) has to be in same name space with the child otherwize, you copy the name space into it

                - Asides for the methods we created which can be inherited, every class can inherits some methods from the object class
             */

            Radio accessMyRadio = new Radio(false, "Sonny"); //radio switched off

            accessMyRadio.SwitchOn(); //radio switched on
            accessMyRadio.ListenToRadio(); //calling the ListenToRadio() method

            //Create a TV object
            TV accessMyTV = new TV(false, "LG"); //TV switched off

            //Using method of the base class
            accessMyTV.SwitchOn(); //TV switched on

            //Using method of the child class
            accessMyTV.WatchTV(); //calling the WatchTV() method
        }
    }

    //both the Radio and the TV classes do not have the switchOn and SwitchOff methods,
    //but they were able to aaccess it from the ElectricalDevice class because they inherited it.
}