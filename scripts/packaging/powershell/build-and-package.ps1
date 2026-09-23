<#
Builds the solution, then packages each certificate store type's extension files
into artifacts\<StoreType>\ via RemoteFile.Packaging.proj's Package target.
#>

$repoRoot = Resolve-Path "$PSScriptRoot\..\..\.."

dotnet build "$repoRoot\RemoteFile.sln"
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }

dotnet build "$repoRoot\RemoteFile.Packaging.proj" -t:Package
exit $LASTEXITCODE
