<script setup lang="ts">

const props = defineProps<{
    id: number,
    name: string,
    surname: string
}>();
const emit = defineEmits(['delete']);

</script>

<template>
    <div class="UserInfo">
        <div>ID {{ id }}</div>
        <div>Name: {{ name }}</div>
        <div>Surname: {{ surname }}</div>
        <div><button @click="emit('delete', id)">Borrar</button></div>
    </div>
</template>