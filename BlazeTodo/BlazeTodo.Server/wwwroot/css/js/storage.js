window.SaveTodos = (todos) => {
    window.localStorage.setItem('todos', todos);
}

window.LoadTodos = () => {
    return window.localStorage.getItem('todos');
}