#!/bin/bash

if [${1,,} = Neves]; then
    echo "Oh, you´re the boss here. Welcome!"
elif [${1,,} = help]; then
    echo "Just enter your username, duh!"
else
    echo "Não sei quem você é mas não é meu chefe"