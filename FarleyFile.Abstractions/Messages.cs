﻿using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

// this is a DSL to define code contract classes without writing them
// Good for starting a project quickly
// pressing Ctrl+S updates CS version immediately
namespace FarleyFile
{
    #region Generated by Lokad Code DSL
    
    [DataContract] public sealed class PerspectiveCreated : IEvent
    {
    }
    
    [DataContract] public sealed class StartSimpleStory : ICommand
    {
        [DataMember(Order = 1)] public string Name { get; internal set; }
        
        internal StartSimpleStory () {}
        public StartSimpleStory (string name)
        {
            Name = name;
        }
    }
    
    [DataContract] public sealed class SimpleStoryStarted : IEvent
    {
        [DataMember(Order = 1)] public StoryId StoryId { get; internal set; }
        [DataMember(Order = 2)] public string Name { get; internal set; }
        
        internal SimpleStoryStarted () {}
        public SimpleStoryStarted (StoryId storyId, string name)
        {
            StoryId = storyId;
            Name = name;
        }
    }
    
    [DataContract] public sealed class ActivityReference
    {
        [DataMember(Order = 1)] public Identity Id { get; internal set; }
        [DataMember(Order = 2)] public string Text { get; internal set; }
        [DataMember(Order = 3)] public string OriginalRef { get; internal set; }
        
        internal ActivityReference () {}
        public ActivityReference (Identity id, string text, string originalRef)
        {
            Id = id;
            Text = text;
            OriginalRef = originalRef;
        }
    }
    
    [DataContract] public sealed class AddActivity : ICommand
    {
        [DataMember(Order = 1)] public string Text { get; internal set; }
        [DataMember(Order = 2)] public DateTimeOffset Time { get; internal set; }
        [DataMember(Order = 3)] public ICollection<ActivityReference> References { get; internal set; }
        
        internal AddActivity () {}
        public AddActivity (string text, DateTimeOffset time, ICollection<ActivityReference> references)
        {
            Text = text;
            Time = time;
            References = references;
        }
    }
    
    [DataContract] public sealed class ActivityAdded : IEvent
    {
        [DataMember(Order = 1)] public string Text { get; internal set; }
        [DataMember(Order = 2)] public DateTimeOffset Time { get; internal set; }
        [DataMember(Order = 3)] public ActivityId ActivityId { get; internal set; }
        [DataMember(Order = 4)] public ICollection<ActivityReference> References { get; internal set; }
        
        internal ActivityAdded () {}
        public ActivityAdded (string text, DateTimeOffset time, ActivityId activityId, ICollection<ActivityReference> references)
        {
            Text = text;
            Time = time;
            ActivityId = activityId;
            References = references;
        }
    }
    
    [DataContract] public sealed class AddNote : ICommand
    {
        [DataMember(Order = 1)] public string Title { get; internal set; }
        [DataMember(Order = 2)] public string Text { get; internal set; }
        [DataMember(Order = 3)] public StoryId StoryId { get; internal set; }
        
        internal AddNote () {}
        public AddNote (string title, string text, StoryId storyId)
        {
            Title = title;
            Text = text;
            StoryId = storyId;
        }
    }
    
    [DataContract] public sealed class NoteAdded : IEvent
    {
        [DataMember(Order = 1)] public NoteId NoteId { get; internal set; }
        [DataMember(Order = 2)] public string Title { get; internal set; }
        [DataMember(Order = 3)] public string Text { get; internal set; }
        
        internal NoteAdded () {}
        public NoteAdded (NoteId noteId, string title, string text)
        {
            NoteId = noteId;
            Title = title;
            Text = text;
        }
    }
    
    [DataContract] public sealed class NoteAssignedToStory : IEvent
    {
        [DataMember(Order = 1)] public NoteId NoteId { get; internal set; }
        [DataMember(Order = 2)] public StoryId StoryId { get; internal set; }
        [DataMember(Order = 3)] public string Title { get; internal set; }
        [DataMember(Order = 4)] public string Text { get; internal set; }
        
        internal NoteAssignedToStory () {}
        public NoteAssignedToStory (NoteId noteId, StoryId storyId, string title, string text)
        {
            NoteId = noteId;
            StoryId = storyId;
            Title = title;
            Text = text;
        }
    }
    
    [DataContract] public sealed class NoteRemovedFromStory : IEvent
    {
        [DataMember(Order = 1)] public NoteId NoteId { get; internal set; }
        [DataMember(Order = 2)] public StoryId StoryId { get; internal set; }
        
        internal NoteRemovedFromStory () {}
        public NoteRemovedFromStory (NoteId noteId, StoryId storyId)
        {
            NoteId = noteId;
            StoryId = storyId;
        }
    }
    
    [DataContract] public sealed class RenameItem : ICommand
    {
        [DataMember(Order = 1)] public Identity Id { get; internal set; }
        [DataMember(Order = 2)] public string Name { get; internal set; }
        
        internal RenameItem () {}
        public RenameItem (Identity id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    
    [DataContract] public sealed class NoteRenamed : IEvent
    {
        [DataMember(Order = 1)] public NoteId NoteId { get; internal set; }
        [DataMember(Order = 2)] public string OldName { get; internal set; }
        [DataMember(Order = 3)] public string NewName { get; internal set; }
        [DataMember(Order = 4)] public ICollection<StoryId> StoryIds { get; internal set; }
        
        internal NoteRenamed () {}
        public NoteRenamed (NoteId noteId, string oldName, string newName, ICollection<StoryId> storyIds)
        {
            NoteId = noteId;
            OldName = oldName;
            NewName = newName;
            StoryIds = storyIds;
        }
    }
    
    [DataContract] public sealed class TaskRenamed : IEvent
    {
        [DataMember(Order = 1)] public TaskId TaskId { get; internal set; }
        [DataMember(Order = 2)] public string OldText { get; internal set; }
        [DataMember(Order = 3)] public string NewText { get; internal set; }
        [DataMember(Order = 4)] public ICollection<StoryId> StoryIds { get; internal set; }
        
        internal TaskRenamed () {}
        public TaskRenamed (TaskId taskId, string oldText, string newText, ICollection<StoryId> storyIds)
        {
            TaskId = taskId;
            OldText = oldText;
            NewText = newText;
            StoryIds = storyIds;
        }
    }
    
    [DataContract] public sealed class SimpleStoryRenamed : IEvent
    {
        [DataMember(Order = 1)] public StoryId StoryId { get; internal set; }
        [DataMember(Order = 2)] public string OldName { get; internal set; }
        [DataMember(Order = 3)] public string NewName { get; internal set; }
        
        internal SimpleStoryRenamed () {}
        public SimpleStoryRenamed (StoryId storyId, string oldName, string newName)
        {
            StoryId = storyId;
            OldName = oldName;
            NewName = newName;
        }
    }
    
    [DataContract] public sealed class EditNote : ICommand
    {
        [DataMember(Order = 1)] public NoteId NoteId { get; internal set; }
        [DataMember(Order = 2)] public string Text { get; internal set; }
        [DataMember(Order = 3)] public string OldText { get; internal set; }
        
        internal EditNote () {}
        public EditNote (NoteId noteId, string text, string oldText)
        {
            NoteId = noteId;
            Text = text;
            OldText = oldText;
        }
    }
    
    [DataContract] public sealed class NoteEdited : IEvent
    {
        [DataMember(Order = 1)] public NoteId NoteId { get; internal set; }
        [DataMember(Order = 2)] public string NewText { get; internal set; }
        [DataMember(Order = 3)] public string OldText { get; internal set; }
        [DataMember(Order = 4)] public ICollection<StoryId> StoryIds { get; internal set; }
        
        internal NoteEdited () {}
        public NoteEdited (NoteId noteId, string newText, string oldText, ICollection<StoryId> storyIds)
        {
            NoteId = noteId;
            NewText = newText;
            OldText = oldText;
            StoryIds = storyIds;
        }
    }
    
    [DataContract] public sealed class NoteRemoved : IEvent
    {
        [DataMember(Order = 1)] public NoteId NoteId { get; internal set; }
        
        internal NoteRemoved () {}
        public NoteRemoved (NoteId noteId)
        {
            NoteId = noteId;
        }
    }
    
    [DataContract] public sealed class MergeNotes : ICommand
    {
        [DataMember(Order = 1)] public NoteId NoteId { get; internal set; }
        [DataMember(Order = 2)] public NoteId Secondary { get; internal set; }
        
        internal MergeNotes () {}
        public MergeNotes (NoteId noteId, NoteId secondary)
        {
            NoteId = noteId;
            Secondary = secondary;
        }
    }
    
    [DataContract] public sealed class AddTask : ICommand
    {
        [DataMember(Order = 1)] public string Text { get; internal set; }
        [DataMember(Order = 2)] public StoryId StoryId { get; internal set; }
        
        internal AddTask () {}
        public AddTask (string text, StoryId storyId)
        {
            Text = text;
            StoryId = storyId;
        }
    }
    
    [DataContract] public sealed class TaskAdded : IEvent
    {
        [DataMember(Order = 1)] public TaskId TaskId { get; internal set; }
        [DataMember(Order = 2)] public string Text { get; internal set; }
        
        internal TaskAdded () {}
        public TaskAdded (TaskId taskId, string text)
        {
            TaskId = taskId;
            Text = text;
        }
    }
    
    [DataContract] public sealed class TaskAssignedToStory : IEvent
    {
        [DataMember(Order = 1)] public TaskId TaskId { get; internal set; }
        [DataMember(Order = 2)] public StoryId StoryId { get; internal set; }
        [DataMember(Order = 3)] public string Text { get; internal set; }
        [DataMember(Order = 4)] public bool Completed { get; internal set; }
        
        internal TaskAssignedToStory () {}
        public TaskAssignedToStory (TaskId taskId, StoryId storyId, string text, bool completed)
        {
            TaskId = taskId;
            StoryId = storyId;
            Text = text;
            Completed = completed;
        }
    }
    
    [DataContract] public sealed class TaskRemovedFromStory : IEvent
    {
        [DataMember(Order = 1)] public TaskId TaskId { get; internal set; }
        [DataMember(Order = 2)] public StoryId StoryId { get; internal set; }
        
        internal TaskRemovedFromStory () {}
        public TaskRemovedFromStory (TaskId taskId, StoryId storyId)
        {
            TaskId = taskId;
            StoryId = storyId;
        }
    }
    
    [DataContract] public sealed class AddToStory : ICommand
    {
        [DataMember(Order = 1)] public Identity ItemId { get; internal set; }
        [DataMember(Order = 2)] public StoryId StoryId { get; internal set; }
        
        internal AddToStory () {}
        public AddToStory (Identity itemId, StoryId storyId)
        {
            ItemId = itemId;
            StoryId = storyId;
        }
    }
    
    [DataContract] public sealed class RemoveFromStory : ICommand
    {
        [DataMember(Order = 1)] public Identity Id { get; internal set; }
        [DataMember(Order = 2)] public StoryId StoryId { get; internal set; }
        
        internal RemoveFromStory () {}
        public RemoveFromStory (Identity id, StoryId storyId)
        {
            Id = id;
            StoryId = storyId;
        }
    }
    
    [DataContract] public sealed class AddTaskToStory : ICommand
    {
        [DataMember(Order = 1)] public TaskId TaskId { get; internal set; }
        [DataMember(Order = 2)] public StoryId StoryId { get; internal set; }
        
        internal AddTaskToStory () {}
        public AddTaskToStory (TaskId taskId, StoryId storyId)
        {
            TaskId = taskId;
            StoryId = storyId;
        }
    }
    
    [DataContract] public sealed class CompleteTask : ICommand
    {
        [DataMember(Order = 1)] public TaskId TaskId { get; internal set; }
        
        internal CompleteTask () {}
        public CompleteTask (TaskId taskId)
        {
            TaskId = taskId;
        }
    }
    
    [DataContract] public sealed class TaskCompleted : IEvent
    {
        [DataMember(Order = 1)] public TaskId TaskId { get; internal set; }
        [DataMember(Order = 2)] public ICollection<StoryId> StoryIds { get; internal set; }
        
        internal TaskCompleted () {}
        public TaskCompleted (TaskId taskId, ICollection<StoryId> storyIds)
        {
            TaskId = taskId;
            StoryIds = storyIds;
        }
    }
    #endregion
}
