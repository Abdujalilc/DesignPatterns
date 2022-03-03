using StrategyDesignPattern;

CompressionContext ctx = new CompressionContext(new ZipCompression());
ctx.CreateArchive("DotNetDesignPattern");
ctx.SetStrategy(new RarCompression());
ctx.CreateArchive("DotNetDesignPattern");
Console.Read();