echo "Enter number1:"
read a
echo "Enter action:"
read ac
echo "Enter number2"
read  b
if [ "$ac" == "+" ];then
    echo "ANSWER"
    echo $(($a + $b))
fi
if [ "$ac" == "-" ];then
    echo "ANSWER"
    echo $(($a - $b))
fi
if [ "$ac" == "*" ];then
    echo "ANSWER"
    echo $(($a * $b))
fi
if [ "$ac" == "/" ];then
    echo "ANSWER"
    echo $(($a / $b))
fi