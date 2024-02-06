<script setup lang="ts">
import TheWelcome from '../components/TheWelcome.vue'
import Name from '../components/Name.vue'
import { ref } from 'vue'

const userName = ref("John");
const counter1 = ref(0);
const counter2 = ref(0);

</script>

<template>
  <main>
    <!--<TheWelcome />-->
    <Name 
    :name="userName" 
    :counter="counter1"
    @increment="counter1++">
    </Name>
    <Name 
    :name="userName" 
    :counter="counter2"
    @increment="counter2++">
    </Name>
  </main>
</template>
