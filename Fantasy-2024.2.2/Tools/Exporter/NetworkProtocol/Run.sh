#!/bin/bash

echo "1. Client"
echo "2. Server"
echo "3. All"

read -n 1 -p "Please select an option:" choice
echo ""
echo ""
case $choice in
    1)
        dotnet Fantasy.Tools.NetworkProtocol.dll --p 1
        ;;
    2)
        dotnet Fantasy.Tools.NetworkProtocol.dll --p 2
        ;;
    3)
        dotnet Fantasy.Tools.NetworkProtocol.dll --p 3
        ;;
    *)
        echo "Invalid option"
        ;;
esac
