#!/bin/sh

codeql=~/apps/codeql/2.6.1/codeql
dbcsharp=~/dev/codeql-dbs/blackmore-csharp
dbjs=~/dev/codeql-dbs/blackmore-js

rm -rf "$dbjs" "$dbcsharp" "db-csharp.zip" "db-js.zip"

$codeql database create -l csharp -s "$(pwd)" "$dbcsharp"
$codeql database bundle "$dbcsharp" -o "db-csharp.zip"

LGTM_INDEX_FILTERS="include:**/*.json" $codeql database create -l javascript -s "$(pwd)" "$dbjs"
$codeql database bundle "$dbjs" -o "db-js.zip"
