#!/usr/bin/env bash
if [ $# -ne 1 ]; then
  echo "Usage: $0 NEW_VERSION_FROM_SEMANTIC_RELEASE"
  exit 1
fi

VERSION="$1"

find . -type f -name '*.csproj' -print0 | xargs -0 -I {} dotnet version --skip-vcs --project-file {} "$VERSION"
