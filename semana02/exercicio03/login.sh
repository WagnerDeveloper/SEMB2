#!/bin/bash

case ${1,,} in
        wagner | administrator)
                echo "hello, you´re the boss here!"
                ;;
        help)
                echo "just enter your username!"
                ;;
        *)
                echo "hello there ..."
esac