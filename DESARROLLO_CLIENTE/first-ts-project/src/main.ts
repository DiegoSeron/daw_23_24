
interface Pedido{
    id: number,
    fecha: undefined | Date,
    customerId: number
}

class Example {
    
    sayHi(name:string){
        console.log(`Hello ${name}`);
        
    }

    add(pedido: Pedido){
        console.log(`process:` + JSON.stringify(pedido));
        
    }
}
let example = new Example();

new Example().sayHi('Diego');
example.add({
    id: 0,
    fecha: undefined,
    customerId: 1
})