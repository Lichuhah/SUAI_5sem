#! /bin/bash

clear

read myrows mycols < <(stty size) 

comandArray=(
	"curl -X GET http://localhost:8080/room/get"
	"curl -X POST -d "name=qw" -d "id=123" http://localhost:8080/room/add"
	"curl -X GET http://localhost:8080/room/get"
	"curl -X DELETE -d "id=123" http://localhost:8080/room/delete"
	"curl -X GET http://localhost:8080/room/get"
	"curl -X POST -d "name=qw" -d "id=123" http://localhost:8080/room/add"
	"curl -X POST -d "name=ad" -d "count=123" -d "roomId=123" http://localhost:8080/obj/add"
	"curl -X GET http://localhost:8080/room/get"
	"curl -X PUT -d "objName=ad" -d "roomId=123" -d "count=1" http://localhost:8080/obj/put"
	"curl -X GET http://localhost:8080/room/get"
	"curl -X DELETE -d "objName=ad" -d "roomId=123" http://localhost:8080/obj/delete"
	"curl -X GET http://localhost:8080/room/get"
)

for ((i = 0; i < ${#comandArray[@]}; i++))
do
	echo -e "\t\033[32m${comandArray[$i]}\033[37m"
    echo
    ${comandArray[$i]}
    echo
    echo
    echo -e "\033[35m\033[45m"
		for ((c = 0 ; c <= (mycols-1) ; c++)); do
		  printf "#"
		done
    echo -e "\033[0m"
done

echo
echo
