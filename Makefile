setup:
	dotnet restore
build:
	dotnet build
test:
	dotnet test 
run:
	dotnet run --project ./AoC2024.Runner
watch-test:
	dotnet watch test --project ./AoC2024.Test/AoC2024.Test.csproj
