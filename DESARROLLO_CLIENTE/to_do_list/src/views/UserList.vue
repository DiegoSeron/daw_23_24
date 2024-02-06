<script setup lang="ts">
import {reactive} from 'vue'
import UserInfo from '../components/UserInfo.vue'


const users =reactive([
    {id: 0, name: 'John', surname: 'foo'},
    {id: 1, name: 'Juan', surname: 'fua'}
])
function deleteUser(id: number){
    console.log(id);
    const index = users.findIndex(user => user.id === id)
    users.splice(index, 1);
}
</script>

<template>
    <div>Lista de usuarios</div>
        <UserInfo v-for="user in users"
            :id="user.id"
            :name="user.name"
            :surname="user.surname"
            @delete="deleteUser">
        </UserInfo>
</template>