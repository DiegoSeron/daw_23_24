<script setup lang="ts">
import HelloWorld from './components/HelloWorld.vue'
import TheWelcome from './components/TheWelcome.vue'
import { reactive,ref } from 'vue';

let counter = ref(0)
let result = ref(0);
let array = reactive(Array<number>());

function addValue(){
  console.log('Call function');
  counter.value++
}

function addValueToArray(){
  array.push(counter.value);
}

function quitLastValueToArray(){
  if(array.length > 0){
    array.pop();
  }else{
    alert("no hay elementos manin")
  }
}
</script>


<template>

    <main>
      <div><button @click="addValue">AñadirDesdeFuncion</button></div>
      <div><button @click="addValueToArray">Añadir elemento al array</button></div>
      <div><button @click="quitLastValueToArray">Quitar Ultimo Elemento del Array</button></div>
      <div class="inLine">
      <div><button @click="counter++">Añadir</button></div>
      <div><button @click="counter--">Quitar</button></div>
    </div>
    <div class="inLine">
      <div><button @click="result = result + counter">Sumar</button></div>
      <div><button @click="result = result - counter">Restar</button></div>
    </div>
      <div>El contador vale: {{ counter }}</div>
      <div>El total vale: {{ result }}</div>
    </main>

    <ul >
      <li v-for="number in array">
        {{ number }}
      </li>
    </ul>

</template>


<style>
  .inLine{
    display: flex;
  }
</style>

