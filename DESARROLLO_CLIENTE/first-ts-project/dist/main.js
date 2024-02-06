"use strict";
class Example {
    sayHi(name) {
        console.log(`Hello ${name}`);
    }
    add(pedido) {
        console.log(`process:` + JSON.stringify(pedido));
    }
}
let example = new Example();
new Example().sayHi('Diego');
example.add({
    id: 0,
    fecha: undefined,
    customerId: 1
});
