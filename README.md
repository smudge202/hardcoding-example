# hardcoding-example
Just an abstract solution to demonstrate hard coding

The solution contains 2 code projects. The `CommandLine` project simply presents the data. For brevity's sake there is a `DisplayData` class in that project that would typically live in a service layer, which in turn will fetch data from `IDataRepository`.

By default, the code will display some hardcoded text, however if you uncomment [this line](https://github.com/smudge202/hardcoding-example/blob/master/Hardcoding/src/CommandLine/Program.cs#L16) it will display text from the database.

Nice and simple, mostly clean (was done very quickly).

**I'm more than happy to walk people through these concepts if they seem foreign to you!**
