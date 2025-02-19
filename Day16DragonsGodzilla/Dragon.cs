public class Dragon : Beast
{
    //  When you declare a virtual method in the parent class
    //  The child class can do other behaviors different to its parent
    //  By overriding it
    public override string HelloWorld()
    {
        // this will call the parent's HelloWorld
        return base.HelloWorld() +  "\nMy dad said hello world, so me too, I am the child, 'Hello World'";
    }
}