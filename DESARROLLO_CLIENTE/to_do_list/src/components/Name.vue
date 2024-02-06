<script setup lang="ts">
// const counter = ref(0)
// const props = defineProps(['name','counter'])
const props = defineProps<{
    name: string,
    counter: number
}>()
const emit = defineEmits(['increment'])
</script>
<template>
    <div>Hola mundo {{ name }}</div>
    <div>El valor del contador es {{ counter }}</div>
    <div><button @click="emit('increment')">Sumar</button></div>
</template>