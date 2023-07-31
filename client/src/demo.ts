let data = 42;
interface ICar {
    color: string,
    model: string,
    topSpeed: number
}
const car1: ICar = {
    color: 'red',
    model: 'mercedes',
    topSpeed: 100
}

const multiply = (x: number, y: number): number => {
    return x * y;
}