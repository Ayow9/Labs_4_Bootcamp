export interface Mountain{
    name: string;
    height: number;
    }
let mountain: Mountain[] = [
        {name: "Kilimanjaro", height: 19341},
        {name: "Everest", height: 29029},
        {name: "Denali", height: 20310}
        ];

function findNameOfTallestMountain(mountains: Mountain[]): string | undefined{
    
    let maxHeight = 0;
    let maxMountain: Mountain | null = null;
    for (let mountain of mountains)
    {
        if (maxHeight < mountain.height)
        {
            maxHeight = mountain.height;
            maxMountain = mountain;
        }
    }
    return maxMountain?.name; //?. == class.propertytype ? is null or undefined 
    };


console.log(findNameOfTallestMountain);


//Call findNameOfTallestMountain, passing it your mountains array as an argument.

//Store the result of the function call (the return value) in a variable and then console.log the variable. (Hint: It will print “Everest”.)

