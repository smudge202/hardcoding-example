# hardcoding-example
Just an abstract solution to demonstrate hard coding

THe solution contains 2 codec projects. The `CommandLine` project simply presents the data. For brevity's sake there is a `DisplayData` class in that project that would typically live in a service layer, which in turn will fetch data from `IDataRepository`.

By default, the code will display some hardcoded text, however if you uncomment [this line](https://github.com/smudge202/hardcoding-example/blob/master/Hardcoding/src/CommandLine/Program.cs#L16) it will display text from the database.

Nice and simple, mostly clean (was done very quickly).
