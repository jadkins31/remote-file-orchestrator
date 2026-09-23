#!/usr/bin/env bash
# Builds the solution, then packages each certificate store type's extension files
# into artifacts/<StoreType>/ via RemoteFile.Packaging.proj's Package target.
set -e

repo_root="$(cd "$(dirname "${BASH_SOURCE[0]}")/../../.." && pwd)"

dotnet build "$repo_root/RemoteFile.sln"
dotnet build "$repo_root/RemoteFile.Packaging.proj" -t:Package
